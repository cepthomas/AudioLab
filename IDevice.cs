using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace AudioLab // Ephemera.MidiLib
{
    /// <summary>Abstraction layer to support all devices.</summary>
    public interface IDevice : IDisposable
    {
        #region Properties
        /// <summary>Friendly name.</summary>
        string Name { get; }

        /// <summary>Device name as defined by the system.</summary>
        string DeviceName { get; }

        /// <summary>Internal id.</summary>
        int Id { get; init; }

        /// <summary>Are we ok?</summary>
        bool Valid { get; }
        #endregion
    }

    /// <summary>Abstraction layer to support input devices.</summary>
    public interface IMidiInputDevice : IDevice
    {
        #region Properties
        /// <summary>Capture on/off.</summary>
        bool CaptureEnable { get; set; }
        #endregion

        #region Events
        /// <summary>Handler for message arrived.</summary>
        event EventHandler<BaseEvent>? MessageReceived;
        #endregion
    }

    /// <summary>Abstraction layer to support output devices.</summary>
    public interface IMidiOutputDevice : IDevice
    {
        #region Functions
        /// <summary>Send midi event. Converts internal to NAudio format.</summary>
        /// <param name="evt"></param>
        void Send(BaseEvent evt);
        #endregion

        #region Events
        /// <summary>Handler for message sent.</summary>
        event EventHandler<BaseEvent>? MessageSent;
        #endregion
    }

    /// <summary>Abstraction layer to support output devices.</summary>
    public interface IWaveOutputDevice : IDevice
    {
        // #region Functions
        // /// <summary>Send midi event. Converts internal to NAudio format.</summary>
        // /// <param name="evt"></param>
        // void Send(BaseEvent evt);
        // #endregion

        // #region Events
        // /// <summary>Handler for message sent.</summary>
        // event EventHandler<BaseEvent>? MessageSent;
        // #endregion
    }


    /////////////////////////////////////////////////////////////////////////
    /////////////////// temp //////////////////
    ///

    //----------------------------------------------------------------
    public class NullOutputDevice : IMidiOutputDevice
    {
        /// <inheritdoc />
        /// Uses 'nullout:{name}' for DeviceName.
        public string DeviceName { get; } = "Invalid";

        /// <inheritdoc />
        public bool Valid { get; set; } = false;

        /// <inheritdoc />
        public int Id { get; init; }

        public string Name => throw new NotImplementedException();

        /// <inheritdoc />
        public event EventHandler<BaseEvent>? MessageSent;

        /// <summary>For test use.</summary>
        public List<BaseEvent> CollectedEvents = [];

        #region Lifecycle
        /// <summary>
        /// Normal constructor. OK to throw in here.
        /// </summary>
        /// <param name="deviceName">Client must supply name of device.</param>
        public NullOutputDevice(string deviceName)
        {
            DeviceName = deviceName;


            //var parts = deviceName.SplitByToken(":");
            //if (parts.Count == 2)
            //{
            //    if (parts[0] == "nullout" && !string.IsNullOrEmpty(parts[1]))
            //    {
            //        DeviceName = deviceName;
            //        Valid = true;
            //    }
            //}

            //if (!Valid)
            //{
            //    throw new ArgumentException($"Invalid device name [{deviceName}]");
            //}
        }

        public void Dispose()
        {
        }
        #endregion

        /// <inheritdoc />
        public void Send(BaseEvent evt)
        {
            MessageSent?.Invoke(this, evt);

            CollectedEvents.Add(evt);
        }
    }

}
