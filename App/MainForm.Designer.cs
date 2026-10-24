using System.Drawing;
using System.Windows.Forms;


using Ephemera.MidiLib;


namespace AudioLab
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;


        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            tvInfo = new Ephemera.NBagOfUis.TextViewer();
            btnAbout = new Button();
            btnKill = new Button();
            chkMonRecv = new CheckBox();
            chkMonSend = new CheckBox();
            btnSettings = new Button();
            timeBar = new TimeBar();
            ddbtnFile = new Ephemera.NBagOfUis.DropDownButton();
            toolTip = new ToolTip(components);
            masterControl1 = new MasterControl();
            menuStrip1 = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            toolStripLabel1 = new ToolStripLabel();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripButton1 = new ToolStripButton();
            toolStripSeparator3 = new ToolStripSeparator();
            toolStripComboBox1 = new ToolStripComboBox();
            toolStripSeparator2 = new ToolStripSeparator();
            channelControl1 = new ChannelControl();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // tvInfo
            // 
            tvInfo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tvInfo.BorderStyle = BorderStyle.FixedSingle;
            tvInfo.Location = new Point(13, 354);
            tvInfo.Margin = new Padding(4, 5, 4, 5);
            tvInfo.Name = "tvInfo";
            tvInfo.Size = new Size(1017, 197);
            tvInfo.TabIndex = 41;
            // 
            // btnAbout
            // 
            btnAbout.FlatStyle = FlatStyle.Flat;
            btnAbout.Image = Properties.Resources.glyphicons_195_question_sign;
            btnAbout.Location = new Point(614, 57);
            btnAbout.Name = "btnAbout";
            btnAbout.Size = new Size(40, 38);
            btnAbout.TabIndex = 44;
            toolTip.SetToolTip(btnAbout, "About");
            btnAbout.UseVisualStyleBackColor = false;
            // 
            // btnKill
            // 
            btnKill.FlatStyle = FlatStyle.Flat;
            btnKill.Image = Properties.Resources.glyphicons_206_electricity;
            btnKill.Location = new Point(522, 57);
            btnKill.Name = "btnKill";
            btnKill.Size = new Size(40, 38);
            btnKill.TabIndex = 47;
            toolTip.SetToolTip(btnKill, "Kill all outputs");
            btnKill.UseVisualStyleBackColor = false;
            // 
            // chkMonRecv
            // 
            chkMonRecv.Appearance = Appearance.Button;
            chkMonRecv.FlatAppearance.CheckedBackColor = Color.PapayaWhip;
            chkMonRecv.FlatStyle = FlatStyle.Flat;
            chkMonRecv.Image = Properties.Resources.glyphicons_213_arrow_down;
            chkMonRecv.Location = new Point(430, 57);
            chkMonRecv.Name = "chkMonRecv";
            chkMonRecv.Size = new Size(40, 38);
            chkMonRecv.TabIndex = 48;
            toolTip.SetToolTip(chkMonRecv, "Monitor receive events");
            chkMonRecv.UseVisualStyleBackColor = false;
            // 
            // chkMonSend
            // 
            chkMonSend.Appearance = Appearance.Button;
            chkMonSend.FlatAppearance.CheckedBackColor = Color.PapayaWhip;
            chkMonSend.FlatStyle = FlatStyle.Flat;
            chkMonSend.Image = Properties.Resources.glyphicons_214_arrow_up;
            chkMonSend.Location = new Point(476, 57);
            chkMonSend.Name = "chkMonSend";
            chkMonSend.Size = new Size(40, 38);
            chkMonSend.TabIndex = 49;
            toolTip.SetToolTip(chkMonSend, "Monitor send events");
            chkMonSend.UseVisualStyleBackColor = false;
            // 
            // btnSettings
            // 
            btnSettings.FlatStyle = FlatStyle.Flat;
            btnSettings.Image = Properties.Resources.glyphicons_137_cogwheel;
            btnSettings.Location = new Point(568, 57);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(40, 38);
            btnSettings.TabIndex = 55;
            toolTip.SetToolTip(btnSettings, "User settings");
            btnSettings.UseVisualStyleBackColor = false;
            // 
            // timeBar
            // 
            timeBar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            timeBar.BackColor = Color.LightYellow;
            timeBar.BorderStyle = BorderStyle.FixedSingle;
            timeBar.Location = new Point(12, 158);
            timeBar.Name = "timeBar";
            timeBar.Size = new Size(1017, 49);
            timeBar.TabIndex = 52;
            // 
            // ddbtnFile
            // 
            ddbtnFile.FlatStyle = FlatStyle.Flat;
            ddbtnFile.Image = Properties.Resources.glyphicons_37_file;
            ddbtnFile.Location = new Point(371, 59);
            ddbtnFile.Name = "ddbtnFile";
            ddbtnFile.Size = new Size(40, 38);
            ddbtnFile.TabIndex = 57;
            toolTip.SetToolTip(ddbtnFile, "Open new or recent script");
            ddbtnFile.UseVisualStyleBackColor = false;
            // 
            // masterControl1
            // 
            masterControl1.Location = new Point(12, 103);
            masterControl1.Name = "masterControl1";
            masterControl1.Size = new Size(911, 49);
            masterControl1.TabIndex = 58;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(18, 18);
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, toolStripMenuItem2 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1047, 27);
            menuStrip1.TabIndex = 59;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(66, 23);
            toolStripMenuItem1.Text = "menu1";
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(66, 23);
            toolStripMenuItem2.Text = "menu2";
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(18, 18);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripLabel1, toolStripSeparator1, toolStripButton1, toolStripSeparator3, toolStripComboBox1, toolStripSeparator2 });
            toolStrip1.Location = new Point(0, 27);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1047, 27);
            toolStrip1.TabIndex = 60;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(69, 24);
            toolStripLabel1.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 27);
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(26, 24);
            toolStripButton1.Text = "toolStripButton1";
            toolStripButton1.Click += toolStripButton1_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 27);
            // 
            // toolStripComboBox1
            // 
            toolStripComboBox1.Name = "toolStripComboBox1";
            toolStripComboBox1.Size = new Size(121, 27);
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 27);
            // 
            // channelControl1
            // 
            channelControl1.Location = new Point(13, 213);
            channelControl1.Name = "channelControl1";
            channelControl1.Size = new Size(308, 58);
            channelControl1.TabIndex = 61;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1047, 556);
            Controls.Add(channelControl1);
            Controls.Add(toolStrip1);
            Controls.Add(masterControl1);
            Controls.Add(ddbtnFile);
            Controls.Add(btnSettings);
            Controls.Add(timeBar);
            Controls.Add(chkMonSend);
            Controls.Add(chkMonRecv);
            Controls.Add(btnKill);
            Controls.Add(btnAbout);
            Controls.Add(tvInfo);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "MainForm";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Ephemera.NBagOfUis.TextViewer tvInfo;
        private Button btnAbout;
        private Button btnKill;
        private CheckBox chkMonRecv;
        private CheckBox chkMonSend;
        private TimeBar timeBar;
        private Button btnSettings;
        private Ephemera.NBagOfUis.DropDownButton ddbtnFile;
        private ToolTip toolTip;
        private MasterControl masterControl1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStrip toolStrip1;
        private ToolStripLabel toolStripLabel1;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton toolStripButton1;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripComboBox toolStripComboBox1;
        private ToolStripSeparator toolStripSeparator2;
        private ChannelControl channelControl1;
    }
}
