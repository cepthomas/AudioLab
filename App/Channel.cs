using System;
using System.Collections.Generic;
using System.Linq;
using Ephemera.NBagOfTricks;


//using Ephemera.MidiLib; //TODO1


namespace AudioLab // Ephemera.MidiLib
{
    #region Types

    /// <summary>Abstraction layer.</summary>
    public interface IChannel : IDisposable
    {
        #region Properties
        /// <summary>Friendly name.</summary>
        string Name { get; }

        // /// <summary>Device name as defined by the system.</summary>
        // string DeviceName { get; }

        // /// <summary>Internal id.</summary>
        // int Id { get; init; }

        // /// <summary>Are we ok?</summary>
        // bool Valid { get; }
        #endregion
    }

    #endregion


    // //----------------------------------------------------------------
    // /// <summary>Describes one midi input channel.</summary>
    // public class InputChannel
    // {
    //     #region Fields
    //     /// <summary>Associated device.</summary>
    //     readonly IInputDevice _device;
    //     #endregion

    //     #region Properties
    //     /// <summary>Channel name - optional.</summary>
    //     public string ChannelName { get; set; } = "";

    //     /// <summary>Actual 1-based midi channel number.</summary>
    //     public int ChannelNumber { get; init; } = MidiDefs.TEMP_CHANNEL;

    //     /// <summary>True if channel is active.</summary>
    //     public bool Enable { get; set; } = true;

    //     /// <summary>Handle for use by scripts.</summary>
    //     public int Handle { get; init; }
    //     #endregion

    //     /// <summary>
    //     /// Constructor with required args.
    //     /// </summary>
    //     /// <param name="device"></param>
    //     /// <param name="channelNumber"></param>
    //     public InputChannel(IInputDevice device, int channelNumber)
    //     {
    //         if (channelNumber is <= MidiDefs.TEMP_CHANNEL or > MidiDefs.NUM_CHANNELS) { throw new ArgumentOutOfRangeException($"channelNumber:{(channelNumber)}"); }

    //         _device = device;
    //         ChannelNumber = channelNumber;
    //         Handle = HandleOps.Create(device.Id, ChannelNumber, false);
    //     }
    // }

    //----------------------------------------------------------------
    /// <summary>Describes one midi output channel.</summary>
    public class MidiOutputChannel
    {
        #region Fields
        /// <summary>Associated device.</summary>
        readonly IMidiOutputDevice _device;

        /// <summary>Instruments from alias file.</summary>
        Dictionary<int, string>? _aliases;

        /// <summary>True if the channel doesn't support named instruments/patches.</summary>
        readonly bool _anonymous = false;

        // Backing fields.
        double _volume = VolumeDefs.DEFAULT_VOLUME;
        #endregion

        #region Properties
        /// <summary>Channel name - optional.</summary>
        public string ChannelName { get; set; } = "";

        /// <summary>Actual 1-based midi channel number.</summary>
        public int ChannelNumber { get; init; } = MidiDefs.TEMP_CHANNEL;

        // /// <summary>Handle for use by scripts.</summary>
        // public int Handle { get; init; }

        /// <summary>True if channel is active.</summary>
        public bool Enable { get; set; } = true;

        public bool IsDrums { get; private set; } = false;

        /// <summary>Current volume.</summary>
        public double Volume
        {
            get { return _volume; }
            set { _volume = MathUtils.Constrain(value, 0, VolumeDefs.MAX_VOLUME); }
        }

        /// <summary>Associated events - optional depending on implementation.</summary>
//        public EventCollection Events { get; set; } = new();

        /// <summary>Info about the device.</summary>
        public string DeviceInfo { get { return $"Dev{_device.Id} {_device.DeviceName}"; } }

        /// <summary>Current instrument/patch number.</summary>
        public int Patch { get; private set; } = -1;

        /// <summary>Current instrument/patch name. Set may update internal collection and sends a midi patch message.</summary>
        public string PatchName
        {
            get { return GetInstrumentName(Patch); }
            set
            {
                var id = GetInstrumentId(value);
                if (id < 0) { throw new ArgumentException($"Invalid patch:{value}"); }
                Patch = id;
                _device.Send(new Patch(ChannelNumber, Patch));
            }
        }
        #endregion

        #region Lifecycle
        /// <summary>
        /// Constructor for patch name aware version.
        /// </summary>
        /// <param name="device"></param>
        /// <param name="channelNumber"></param>
        public MidiOutputChannel(IMidiOutputDevice device, int channelNumber)
        {
            if (channelNumber is <= MidiDefs.TEMP_CHANNEL or > MidiDefs.NUM_CHANNELS) { throw new ArgumentOutOfRangeException($"channelNumber:{(channelNumber)}"); }

            _device = device;
            ChannelNumber = channelNumber;
            _volume = VolumeDefs.DEFAULT_VOLUME;
            // Handle = HandleOps.Create(device.Id, ChannelNumber, true);
        }

        /// <summary>
        /// Constructor for anonymous patch version.
        /// </summary>
        /// <param name="device"></param>
        /// <param name="channelNumber"></param>
        /// <param name="patch"></param>
        public MidiOutputChannel(IMidiOutputDevice device, int channelNumber, int patch)
        {
            if (channelNumber is <= MidiDefs.TEMP_CHANNEL or > MidiDefs.NUM_CHANNELS) { throw new ArgumentOutOfRangeException($"channelNumber:{(channelNumber)}"); }

            _device = device;
            ChannelNumber = channelNumber;
            Patch = patch;
            _anonymous = true;
            _volume = VolumeDefs.DEFAULT_VOLUME;
            //   Handle = HandleOps.Create(device.Id, ChannelNumber, true);
        }
        #endregion

        #region Public functions
        /// <summary>
        /// Get instrument name from id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>The instrument name or a fabricated one if unknown.</returns>
        public string GetInstrumentName(int id)
        {
            if (id is < 0 or > MidiDefs.MAX_MIDI) { throw new ArgumentOutOfRangeException($"Instrument:{id}"); }

            string? name = null;

            if (_anonymous)
            {
                name = $"INST_{id}";
            }
            else if (_aliases is not null)
            {
                _aliases.TryGetValue(id, out name);
            }
            else if (IsDrums)
            {
//                name = MidiDefs.DrumKits.GetName(id);
            }
            else
            {
 //               name = MidiDefs.Instruments.GetName(id);
            }

            if (name is null) { throw new ArgumentException($"Invalid instrument id:{id}"); }

            return name;
        }

        /// <summary>
        /// Fix up instrument and patch names - depends on flavor is GM/drums/aliased.
        /// </summary>
        /// <param name="patchName"></param>
        /// <param name="aliasFile"></param>
        /// <exception cref="MidiLibException"></exception>
        public void InitInstruments(string patchName, string? aliasFile = null)
        {
            if (_anonymous) return; // should never happen

            if (aliasFile is not null) // explicit defs file
            {
                try
                {
                    var ir = new IniReader();
                    ir.ParseFile(aliasFile);
                    _aliases = [];

                    var defs = ir.GetValues("instruments");

                    defs.ForEach(kv =>
                    {
                        int id = int.Parse(kv.Key); // can throw
                        if (id is < 0 or > MidiDefs.MAX_MIDI) { throw new ArgumentOutOfRangeException($"Instrument:{id}"); }
                        if (kv.Value.Length == 0) { throw new ArgumentOutOfRangeException($"{id} has no value"); }

                        _aliases.Add(id, kv.Value);

                        if (kv.Value == patchName)
                        {
                            Patch = id;
                        }
                    });
                }
                catch (Exception ex)
                {
                    throw new MidiLibException($"Failed to load alias file {aliasFile}: {ex.Message}");
                }
            }
            else // internal set
            {
                //var id = MidiDefs.DrumKits.GetId(patchName);
                //if (id >= 0) // GM drum kit
                //{
                //    IsDrums = true;
                //    Patch = id;
                //}
                //else
                //{
                //    id = MidiDefs.Instruments.GetId(patchName);
                //    if (id >= 0) // plain GM instrument
                //    {
                //        IsDrums = false;
                //        Patch = id;
                //    }
                //    else // unknown
                //    {
                //        throw new ArgumentException($"Invalid instrument:{patchName}");
                //    }
                //}
            }

            if (Patch is < 0 or > MidiDefs.MAX_MIDI) { throw new ArgumentOutOfRangeException($"Unresolved patch:{patchName}"); }

            _device.Send(new Patch(ChannelNumber, Patch));
        }

        /// <summary>
        /// Hide direct device access.
        /// </summary>
        /// <param name="evt"></param>
        public void Send(BaseEvent evt)
        {
            _device.Send(evt);
        }
        #endregion

        #region Private functions
        /// <summary>
        /// Sort out possible sources of id.
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        int GetInstrumentId(string name)
        {
            int id = -1;

            if (_aliases is not null)
            {
                var i = _aliases.Where(v => v.Value == name);
                id = i.Any() ? i.First().Key : -1;
            }
            //else if (IsDrums)
            //{
            //    id = MidiDefs.Drums.GetId(name);
            //}
            //else
            //{
            //    id = MidiDefs.Instruments.GetId(name);
            //}

            return id;
        }
        #endregion
    }
}
