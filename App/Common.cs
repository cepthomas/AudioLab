using System;
using System.Collections.Generic;
using System.Linq;


namespace AudioLab // Ephemera.MidiLib
{
    /// <summary>Library error.</summary>
    public class MidiLibException(string message) : Exception(message) { }

    /// <summary>User selection options.</summary>
    public enum SnapType { Tick, Beat, Bar, FourBar }

    /// <summary>Misc definitions.</summary>
    public class VolumeDefs
    {
        /// <summary>Default value.</summary>
        public const double DEFAULT_VOLUME = 0.8;

        /// <summary>Allow UI controls some more headroom.</summary>
        public const double MAX_VOLUME = 2.0;
    }

    public class MidiDefs
    {
        #region Fields
        /// <summary>Midi constant.</summary>
        public const int MAX_MIDI = 127;

        /// <summary>Per device.</summary>
        public const int NUM_CHANNELS = 16;

        /// <summary>Invalid channel number is ok in transition.</summary>
        public const int TEMP_CHANNEL = 0;

        /// <summary>The normal drum channel.</summary>
        public const int DEFAULT_DRUM_CHANNEL = 10;
        #endregion
    }



    //----------------------------------------------------------------
    /// <summary>Base class for internal representation of midi events.</summary>
    public class BaseEvent
    {
        /// <summary>Channel number.</summary>
        public int ChannelNumber
        {
            get { return _channelNumber; }
            set
            {
                if (value is < MidiDefs.TEMP_CHANNEL or > MidiDefs.NUM_CHANNELS) throw new ArgumentOutOfRangeException($"ChannelNumber:{value}");
                _channelNumber = value;
            }
        }
        int _channelNumber = 0;

        ///// <summary>When to send. ZERO means unknown or don't care.</summary>
        //public MusicTime When { get; set; } = MusicTime.ZERO;

        /// <summary>If true, delete after sending.</summary>
        public bool Transient { get; set; } = false;

        ///// <summary>Read me.</summary>
        //public override string ToString()
        //{
        //    return $"ChannelNumber:{ChannelNumber} When:{When}";
        //}
    }

    public class Patch : BaseEvent
    {
        public Patch(int channel, int value) //, MusicTime? when = null)
        {

        }

    }

}
