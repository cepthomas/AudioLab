namespace AudioLab
{
    partial class MasterControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        //private void InitializeComponent()
        //{
        //    SuspendLayout();
        //    // 
        //    // MasterControl
        //    // 
        //    AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
        //    AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        //    Name = "MasterControl";
        //    Size = new System.Drawing.Size(712, 156);
        //    ResumeLayout(false);
        //}


        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            ToolStrip = new System.Windows.Forms.ToolStrip();
            btnLoop = new System.Windows.Forms.ToolStripButton();
            toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            sldVolume = new Ephemera.NBagOfUis.ToolStripSlider();
            toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            btnPlay = new System.Windows.Forms.ToolStripButton();
            toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            btnRewind = new System.Windows.Forms.ToolStripButton();
            toolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            txtBPM = new System.Windows.Forms.ToolStripTextBox();
            toolStripSeparator12 = new System.Windows.Forms.ToolStripSeparator();
            toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            cmbSelMode = new System.Windows.Forms.ToolStripComboBox();
            toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            toolTip = new System.Windows.Forms.ToolTip(components);
            ToolStrip.SuspendLayout();
            SuspendLayout();
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new System.Drawing.Size(6, 6);
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new System.Drawing.Size(243, 6);
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new System.Drawing.Size(243, 6);
            // 
            // toolStripSeparator8
            // 
            toolStripSeparator8.Name = "toolStripSeparator8";
            toolStripSeparator8.Size = new System.Drawing.Size(6, 6);
            // 
            // ToolStrip
            // 
            ToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { btnLoop, toolStripSeparator6, sldVolume, toolStripSeparator7, btnPlay, toolStripSeparator9, btnRewind, toolStripSeparator11, toolStripLabel1, txtBPM, toolStripSeparator12, toolStripLabel2, cmbSelMode, toolStripSeparator4 });
            ToolStrip.Location = new System.Drawing.Point(0, 0);
            ToolStrip.Name = "ToolStrip";
            ToolStrip.Size = new System.Drawing.Size(795, 43);
            ToolStrip.TabIndex = 1;
            ToolStrip.Text = "toolStrip";
            // 
            // btnLoop
            // 
            btnLoop.AutoSize = false;
            btnLoop.CheckOnClick = true;
            btnLoop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            btnLoop.Image = Properties.Resources.glyphicons_82_refresh;
            btnLoop.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            btnLoop.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnLoop.Name = "btnLoop";
            btnLoop.Size = new System.Drawing.Size(40, 40);
            btnLoop.Text = "toolStripButton1";
            btnLoop.ToolTipText = "Loop forever";
            // 
            // toolStripSeparator6
            // 
            toolStripSeparator6.Name = "toolStripSeparator6";
            toolStripSeparator6.Size = new System.Drawing.Size(6, 43);
            // 
            // sldVolume
            // 
            sldVolume.AccessibleName = "sldVolume";
            sldVolume.AutoSize = false;
            sldVolume.Name = "sldVolume";
            sldVolume.Size = new System.Drawing.Size(150, 38);
            sldVolume.Text = "vol";
            sldVolume.ToolTipText = "Master volume";
            // 
            // toolStripSeparator7
            // 
            toolStripSeparator7.Name = "toolStripSeparator7";
            toolStripSeparator7.Size = new System.Drawing.Size(6, 43);
            // 
            // btnPlay
            // 
            btnPlay.AutoSize = false;
            btnPlay.CheckOnClick = true;
            btnPlay.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            btnPlay.Image = Properties.Resources.glyphicons_174_play;
            btnPlay.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            btnPlay.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnPlay.Name = "btnPlay";
            btnPlay.Size = new System.Drawing.Size(40, 40);
            btnPlay.Text = "toolStripButton1";
            btnPlay.ToolTipText = "Play or stop";
            // 
            // toolStripSeparator9
            // 
            toolStripSeparator9.Name = "toolStripSeparator9";
            toolStripSeparator9.Size = new System.Drawing.Size(6, 43);
            // 
            // btnRewind
            // 
            btnRewind.AutoSize = false;
            btnRewind.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            btnRewind.Image = Properties.Resources.glyphicons_173_rewind;
            btnRewind.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            btnRewind.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnRewind.Name = "btnRewind";
            btnRewind.Size = new System.Drawing.Size(40, 40);
            btnRewind.Text = "toolStripButton1";
            btnRewind.ToolTipText = "Rewind";
            // 
            // toolStripSeparator11
            // 
            toolStripSeparator11.Name = "toolStripSeparator11";
            toolStripSeparator11.Size = new System.Drawing.Size(6, 43);
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new System.Drawing.Size(41, 40);
            toolStripLabel1.Text = "BPM:";
            // 
            // txtBPM
            // 
            txtBPM.AutoSize = false;
            txtBPM.Name = "txtBPM";
            txtBPM.Size = new System.Drawing.Size(70, 43);
            txtBPM.ToolTipText = "BPM for beat mode";
            // 
            // toolStripSeparator12
            // 
            toolStripSeparator12.Name = "toolStripSeparator12";
            toolStripSeparator12.Size = new System.Drawing.Size(6, 43);
            // 
            // toolStripLabel2
            // 
            toolStripLabel2.Name = "toolStripLabel2";
            toolStripLabel2.Size = new System.Drawing.Size(47, 40);
            toolStripLabel2.Text = "Select:";
            // 
            // cmbSelMode
            // 
            cmbSelMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbSelMode.Name = "cmbSelMode";
            cmbSelMode.Size = new System.Drawing.Size(90, 43);
            cmbSelMode.ToolTipText = "Selection mode";
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new System.Drawing.Size(6, 43);
            // 
            // MasterControl
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(ToolStrip);
            Name = "MasterControl";
            Size = new System.Drawing.Size(795, 43);
            ToolStrip.ResumeLayout(false);
            ToolStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }


        #endregion

        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStrip ToolStrip;

        // private Ephemera.NBagOfUis.FilTree ftree;
        // private Ephemera.NBagOfUis.TextViewer tvInfo;
        private Ephemera.NBagOfUis.ToolStripSlider sldVolume;

        // private System.Windows.Forms.ToolStripMenuItem FileMenuItem;
        // private System.Windows.Forms.ToolStripMenuItem ToolsMenuItem;
        // private System.Windows.Forms.ToolStripMenuItem AboutMenuItem;
        // private System.Windows.Forms.ToolStripMenuItem SettingsMenuItem;
        // private System.Windows.Forms.ToolStripMenuItem OpenMenuItem;
        // private System.Windows.Forms.ToolStripMenuItem RecentMenuItem;
        // private System.Windows.Forms.ToolStripMenuItem CloseMenuItem;
        // private System.Windows.Forms.ToolStripMenuItem ExitMenuItem;
        // private System.Windows.Forms.ToolStripMenuItem CloseAllMenuItem;
        // private System.Windows.Forms.ToolStripMenuItem ResampleMenuItem;
        // private System.Windows.Forms.ToolStripMenuItem SplitStereoMenuItem;
        // private System.Windows.Forms.ToolStripMenuItem ToMonoMenuItem;
        // private System.Windows.Forms.ToolStripMenuItem SaveAsMenuItem;

        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator11;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator12;

        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;

        private System.Windows.Forms.ToolStripTextBox txtBPM;
        private System.Windows.Forms.ToolStripButton btnPlay;
        private System.Windows.Forms.ToolStripComboBox cmbSelMode;
        private System.Windows.Forms.ToolStripButton btnLoop;
        private System.Windows.Forms.ToolStripButton btnRewind;
        // private System.Windows.Forms.Timer timer;

    }
}
