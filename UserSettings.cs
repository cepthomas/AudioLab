using System;
using System.Collections.Generic;
using System.IO;
using System.ComponentModel;
using System.Drawing;
using System.Text.Json;
using System.Text.Json.Serialization;
using Ephemera.NBagOfTricks;


namespace AudioLab // was Nebulua
{
    [Serializable]
    public sealed class UserSettings : SettingsCore
    {
        #region Properties - persisted editable
        [DisplayName("Script Path")]
        [Description("Default location for user scripts.")]
        [Browsable(true)]
        //[Editor(typeof(FolderNameEditor), typeof(UITypeEditor))]
        public string ScriptPath { get; set; } = "";

        [DisplayName("Open Last File")]
        [Description("Open last file on start.")]
        [Browsable(true)]
        public bool OpenLastFile { get; set; } = true;

        [DisplayName("Auto Reload")]
        [Description("Automatically reload current file when play is pressed if it is changed.")]
        [Browsable(true)]
        public bool AutoReload { get; set; } = true;

        [DisplayName("File Log Level")]
        [Description("Log level for file write.")]
        [Browsable(true)]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public LogLevel FileLogLevel { get; set; } = LogLevel.Trace;

        [DisplayName("Notification Log Level")]
        [Description("Log level for UI notification.")]
        [Browsable(true)]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public LogLevel NotifLogLevel { get; set; } = LogLevel.Debug;

        [DisplayName("Icon Color")]
        [Description("Button icons.")]
        [Browsable(true)]
        [JsonConverter(typeof(JsonColorConverter))]
        public Color IconColor { get; set; } = Color.Purple;

        [DisplayName("Active Color")]
        [Description("Active control surfaces.")]
        [Browsable(true)]
        [JsonConverter(typeof(JsonColorConverter))]
        public Color DrawColor { get; set; } = Color.DodgerBlue;

        [DisplayName("Selected Color")]
        [Description("The color used for selected controls.")]
        [Browsable(true)]
        [JsonConverter(typeof(JsonColorConverter))]
        public Color SelectedColor { get; set; } = Color.Moccasin;
        #endregion

        #region Properties - internal
        [Browsable(false)]
        public bool WordWrap { get; set; } = false;

        [Browsable(false)]
        public bool MonitorRecv { get; set; } = false;

        [Browsable(false)]
        public bool MonitorSend { get; set; } = false;
        #endregion
    }


        // #region Persisted editable properties
        // [DisplayName("Auto Close")]
        // [Description("Automatically close after playing the file.")]
        // [Browsable(true)]
        // public bool AutoClose { get; set; } = true;

        // [DisplayName("Control Color")]
        // [Description("The color used for active control surfaces.")]
        // [Browsable(true)]
        // [JsonConverter(typeof(JsonColorConverter))]
        // public Color DrawColor { get; set; } = Color.MediumOrchid;

        // [DisplayName("Selection Color")]
        // [Description("The color used for selections.")]
        // [Browsable(true)]
        // [JsonConverter(typeof(JsonColorConverter))]
        // public Color SelectedColor { get; set; } = Color.LightYellow;

        // [DisplayName("Debug")]
        // [Description("Do not press this!!!")]
        // [Browsable(false)] // Hide for now.
        // public bool Debug { get; set; } = false;

        // [DisplayName("File Log Level")]
        // [Description("Log level for file write.")]
        // [Browsable(true)]
        // [JsonConverter(typeof(JsonStringEnumConverter))]
        // public LogLevel FileLogLevel { get; set; } = LogLevel.Trace;

        // [DisplayName("File Log Level")]
        // [Description("Log level for UI notification.")]
        // [Browsable(true)]
        // [JsonConverter(typeof(JsonStringEnumConverter))]
        // public LogLevel NotifLogLevel { get; set; } = LogLevel.Debug;

        // [DisplayName("Midi Device")]
        // [Description("Midi Device.")]
        // [Browsable(true)]
        // [Editor(typeof(GenericListTypeEditor), typeof(UITypeEditor))]
        // public string MidiDeviceName { get; set; } = "";

        // [DisplayName("Wave Output Device")]
        // [Description("How to play the audio files.")]
        // [Browsable(true)]
        // [TypeConverter(typeof(AudioSettingsConverter))]
        // public string WavOutDevice { get; set; } = "Microsoft Sound Mapper";

        // [DisplayName("Latency")]
        // [Description("What's the hurry?")]
        // [Browsable(true)]
        // [TypeConverter(typeof(AudioSettingsConverter))]
        // public string Latency { get; set; } = "200";
        // #endregion

        // #region Persisted Non-editable Properties
        // [Browsable(false)]
        // public double Volume { get; set; } = 0.7;
        // #endregion



    // [Serializable]
    // public sealed class UserSettings : SettingsCore
    // {
    //     #region Persisted Editable Properties
    //     [DisplayName("Control Color")]
    //     [Description("The color used for active control surfaces.")]
    //     [Browsable(true)]
    //     [JsonConverter(typeof(JsonColorConverter))]
    //     public Color DrawColor { get; set; } = Color.MediumOrchid;

    //     [DisplayName("Wave Color")]
    //     [Description("Pick what you like.")]
    //     [Browsable(true)]
    //     [JsonConverter(typeof(JsonColorConverter))]
    //     public Color WaveColor { get; set; } = Color.ForestGreen;

    //     [DisplayName("Auto Convert Stereo")]
    //     [Description("Automatically convert stereo files to mono otherwise ask.")]
    //     [Browsable(true)]
    //     public bool AutoConvert { get; set; } = false;

    //     [DisplayName("File Log Level")]
    //     [Description("Log level for file write.")]
    //     [Browsable(true)]
    //     [JsonConverter(typeof(JsonStringEnumConverter))]
    //     public LogLevel FileLogLevel { get; set; } = LogLevel.Trace;

    //     [DisplayName("File Log Level")]
    //     [Description("Log level for UI notification.")]
    //     [Browsable(true)]
    //     [JsonConverter(typeof(JsonStringEnumConverter))]
    //     public LogLevel NotifLogLevel { get; set; } = LogLevel.Debug;

    //     [DisplayName("Root Paths")]
    //     [Description("Your favorite places.")]
    //     [Browsable(true)]
    //     [Editor(typeof(StringListEditor), typeof(UITypeEditor))]
    //     public List<string> RootDirs { get; set; } = [];

    //     [DisplayName("Ignore Paths")]
    //     [Description("Ignore these noisy directories.")]
    //     [Browsable(true)]
    //     [Editor(typeof(StringListEditor), typeof(UITypeEditor))]
    //     public List<string> IgnoreDirs { get; set; } = [];

    //     [DisplayName("Single Click Select")]
    //     [Description("Generate event with single or double click.")]
    //     [Browsable(true)]
    //     public bool SingleClickSelect { get; set; } = false;

    //     [DisplayName("Wave Output Device")]
    //     [Description("How to play the audio files.")]
    //     [Browsable(true)]
    //     [TypeConverter(typeof(AudioSettingsConverter))]
    //     public string WavOutDevice { get; set; } = "Microsoft Sound Mapper";

    //     [DisplayName("Latency")]
    //     [Description("What's the hurry?")]
    //     [Browsable(true)]
    //     [TypeConverter(typeof(AudioSettingsConverter))]
    //     public string Latency { get; set; } = "200";
    //     #endregion

    //     #region Persisted Non-editable Persisted Properties
    //     [Browsable(false)]
    //     public bool Autoplay { get; set; } = true;

    //     [Browsable(false)]
    //     public bool Loop { get; set; } = false;

    //     [Browsable(false)]
    //     public double Volume { get; set; } = AudioLibDefs.MAX_VOLUME / 2;

    //     [Browsable(false)]
    //     [JsonConverter(typeof(JsonStringEnumConverter))]
    //     public WaveSelectionMode SelectionMode { get; set; } = WaveSelectionMode.Time;

    //     [Browsable(false)]
    //     public double BPM { get; set; } = 100.0;

    //     [Browsable(false)]
    //     public int SplitterPosition { get; set; } = 30;
    //     #endregion
    // }

}
