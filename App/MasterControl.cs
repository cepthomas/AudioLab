using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Ephemera.NBagOfUis;

// run, rewind, tempo etc


namespace AudioLab
{
    public partial class MasterControl : UserControl
    {

        #region Fields
        ///// <summary>My logger.</summary>
        //readonly Logger _logger = LogManager.CreateLogger("Main");

        /// <summary>Where we be.</summary>
        AppState _currentState = AppState.Stop;

        /// <summary>The settings.</summary>
        readonly UserSettings _settings = new();
        #endregion


        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool Loop { get; set; }


        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public AppState State { get; set; } = AppState.Stop;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public double Volume { get; set; }


        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public double Tempo { get; set; }


        #region Types
        /// <summary>What are we doing.</summary>
        public enum AppState { Stop, Play, Rewind, Complete, Dead }
        #endregion

        #region Lifecycle
        public MasterControl()
        {
            InitializeComponent();

            // KeyPreview = true; // for routing kbd strokes through OnKeyDown first.


            // Other UI items.
            ToolStrip.Renderer = new ToolStripCheckBoxRenderer() { SelectedColor = _settings.DrawColor };


            btnLoop.Checked = _settings.Loop;
            btnLoop.Click += (_, __) => _settings.Loop = btnLoop.Checked;

            sldVolume.DrawColor = _settings.DrawColor;
            sldVolume.Value = _settings.Volume;
            //sldVolume.ValueChanged += (_, __) => _player.Volume = (float)sldVolume.Value;


            GraphicsUtils.ColorizeControl(btnPlay, _settings.IconColor);
            btnPlay.BackColor = BackColor;
//>>>            btnPlay.CheckedBackColor = _settings.SelectedColor;
//>>>            btnPlay.Click += Play_Click;

            GraphicsUtils.ColorizeControl(btnLoop, _settings.IconColor);
            btnLoop.BackColor = BackColor;
            //            btnLoop.FlatAppearance.CheckedBackColor = _settings.SelectedColor;
            //            btnLoop.Click += (_, __) => timeBar.DoLoop = btnLoop.Checked;


            btnRewind.BackColor = BackColor;
            GraphicsUtils.ColorizeControl(btnRewind, _settings.IconColor);
 //>>>           btnRewind.Click += Rewind_Click;


            sldVolume.BackColor = BackColor;
            sldVolume.DrawColor = _settings.DrawColor;
            sldVolume.ValueChanged += (_, __) => Volume = sldVolume.Value;

            //sldTempo.BackColor = BackColor;
            //sldTempo.DrawColor = _settings.DrawColor;
//>>>            sldTempo.ValueChanged += (_, __) => { SetTimer((int)sldTempo.Value); };




            //Globals.BPM = _settings.BPM;
            //txtBPM.Text = Globals.BPM.ToString();
            //txtBPM.KeyPress += (sender, e) => TestForNumber_KeyPress(sender!, e);
            //txtBPM.LostFocus += (_, __) => Globals.BPM = double.Parse(txtBPM.Text);

            //cmbSelMode.Items.Add(WaveSelectionMode.Time);
            //cmbSelMode.Items.Add(WaveSelectionMode.Bar);
            //cmbSelMode.Items.Add(WaveSelectionMode.Sample);
            //cmbSelMode.SelectedIndexChanged += (_, __) =>
            //{
            //    if (cmbSelMode.SelectedItem is not null)
            //    {
            //        _settings.SelectionMode = (WaveSelectionMode)cmbSelMode.SelectedItem;
            //        switch (_settings.SelectionMode)
            //        {
            //            case WaveSelectionMode.Time: Globals.ConverterOps = new TimeOps(); break;
            //            case WaveSelectionMode.Bar: Globals.ConverterOps = new BarOps(); break;
            //            case WaveSelectionMode.Sample: Globals.ConverterOps = new SampleOps(); break;
            //        }
            //        ActiveClipEditor()?.Invalidate();
            //    }
            //};
            //cmbSelMode.SelectedItem = _settings.SelectionMode;

            btnRewind.Click += (_, __) => UpdateState(AppState.Rewind);
            btnPlay.Click += (_, __) => UpdateState(btnPlay.Checked ? AppState.Play : AppState.Stop);

            UpdateUi();
        }

        #endregion

        #region State management
        /// <summary>
        /// General state management. Everything goes through here.
        /// </summary>
        void UpdateState(AppState newState)
        {
            // Unhook temporarily.
            btnPlay.CheckedChanged -= ChkPlay_CheckedChanged;

            if (newState != _currentState)
            {
                //_logger.Info($"State change:{newState}");
            }

            switch (newState)
            {
                case AppState.Complete:
                    Rewind();
                    if (_settings.Loop)
                    {
                        Play();
                    }
                    else
                    {
                        Stop();
                    }
                    break;

                case AppState.Play:
                    Play();
                    break;

                case AppState.Stop:
                    Stop();
                    break;

                case AppState.Rewind:
                    Rewind();
                    break;

                case AppState.Dead:
                    Stop();
                    break;
            }

            _currentState = newState;

            // Rehook.
            btnPlay.CheckedChanged += ChkPlay_CheckedChanged;

            // Local funcs
            void Play()
            {
                btnPlay.Checked = true;
                //_player.Run(true);
                //if(!_player.Playing)
                //{
                //    _logger.Error($"Player won't run");
                //    btnPlay.Checked = false;
                //}
            }

            void Stop()
            {
                btnPlay.Checked = false;
                //_player.Run(false);
            }

            void Rewind()
            {
                //var cled = ActiveClipEditor();
                //cled?.Rewind();
            }
        }

        /// <summary>
        /// Play button handler.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void ChkPlay_CheckedChanged(object? sender, EventArgs e)
        {
            UpdateState(btnPlay.Checked ? AppState.Play : AppState.Stop);
        }

        /// <summary>
        /// Usually end of file but could be error.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        //void Player_PlaybackStopped(object? sender, StoppedEventArgs e)
        //{
        //    if (e.Exception is not null)
        //    {
        //        _logger.Error($"Other NAudio error: {e.Exception.Message}");
        //        UpdateState(AppState.Dead);
        //    }
        //    else
        //    {
        //        UpdateState(AppState.Complete);
        //    }
        //}

        // /// <summary>
        // /// Do some global key handling. Space bar is used for stop/start playing.
        // /// </summary>
        // /// <param name="e"></param>
        // protected override void OnKeyDown(KeyEventArgs e)
        // {
        //     switch (e.KeyCode)
        //     {
        //         case Keys.Space:
        //             // Toggle.
        //             UpdateState(btnPlay.Checked ? AppState.Stop : AppState.Play);
        //             e.Handled = true;
        //             break;
        //     }

        //     base.OnKeyDown(e);
        // }

        /// <summary>
        /// Set UI item enables according to system states.
        /// </summary>
        void UpdateUi()
        {
            bool anyOpen = false;
            bool anyDirty = false;
            bool currentDirty = false;

            btnRewind.Enabled = anyOpen;
            btnPlay.Enabled = anyOpen;

            //OpenMenuItem.Enabled = true;
            //SaveAsMenuItem.Enabled = currentDirty;
            //CloseMenuItem.Enabled = anyOpen;
            //CloseAllMenuItem.Enabled = anyOpen;
            //ExitMenuItem.Enabled = true;

            //AboutMenuItem.Enabled = true;
            //SettingsMenuItem.Enabled = true;

            //ResampleMenuItem.Enabled = true;
            //SplitStereoMenuItem.Enabled = true;
            //ToMonoMenuItem.Enabled = true;
        }
        #endregion

        // #region Utilities
        // /// <summary>
        // /// 
        // /// </summary>
        // void Resample()
        // {
        //     var fn = GetUserFileName(true);
        //     if (fn != "")
        //     {
        //         var ok = NAudioEx.Convert(Conversion.Resample, fn);
        //         if (!ok)
        //         {
        //             _logger.Warn($"{fn} is already 44.1k");
        //         }
        //     }
        // }

        // /// <summary>
        // /// 
        // /// </summary>
        // void SplitStereo()
        // {
        //     var fn = GetUserFileName(false);
        //     if (fn != "")
        //     {
        //         var ok = NAudioEx.Convert(Conversion.SplitStereo, fn);
        //         if (!ok)
        //         {
        //             _logger.Warn($"{fn} is a mono file");
        //         }
        //     }
        // }
        // #endregion
    }
}
