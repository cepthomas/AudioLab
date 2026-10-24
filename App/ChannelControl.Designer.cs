namespace AudioLab
{
    partial class ChannelControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            sldVolume = new Ephemera.NBagOfUis.Slider();
            panPan = new Ephemera.NBagOfUis.Pan();
            meter1 = new Ephemera.NBagOfUis.Meter();
            lblSolo = new System.Windows.Forms.Label();
            lblMute = new System.Windows.Forms.Label();
            lblInfo = new System.Windows.Forms.Label();
            btnFx = new System.Windows.Forms.Button();
            toolTip = new System.Windows.Forms.ToolTip(components);
            SuspendLayout();
            // 
            // sldVolume
            // 
            sldVolume.Location = new System.Drawing.Point(11, 9);
            sldVolume.Name = "sldVolume";
            sldVolume.Size = new System.Drawing.Size(89, 34);
            sldVolume.TabIndex = 0;
            // 
            // panPan
            // 
            panPan.Location = new System.Drawing.Point(106, 9);
            panPan.Name = "panPan";
            panPan.Size = new System.Drawing.Size(76, 34);
            panPan.TabIndex = 1;
            // 
            // meter1
            // 
            meter1.Location = new System.Drawing.Point(221, 9);
            meter1.Name = "meter1";
            meter1.Size = new System.Drawing.Size(82, 34);
            meter1.TabIndex = 2;
            // 
            // lblSolo
            // 
            lblSolo.AutoSize = true;
            lblSolo.Location = new System.Drawing.Point(261, 80);
            lblSolo.Name = "lblSolo";
            lblSolo.Size = new System.Drawing.Size(45, 19);
            lblSolo.TabIndex = 3;
            lblSolo.Text = "label1";
            // 
            // lblMute
            // 
            lblMute.AutoSize = true;
            lblMute.Location = new System.Drawing.Point(262, 107);
            lblMute.Name = "lblMute";
            lblMute.Size = new System.Drawing.Size(45, 19);
            lblMute.TabIndex = 4;
            lblMute.Text = "label2";
            // 
            // lblInfo
            // 
            lblInfo.AutoSize = true;
            lblInfo.Location = new System.Drawing.Point(26, 81);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new System.Drawing.Size(45, 19);
            lblInfo.TabIndex = 5;
            lblInfo.Text = "label3";
            // 
            // btnFx
            // 
            btnFx.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnFx.Location = new System.Drawing.Point(16, 128);
            btnFx.Name = "btnFx";
            btnFx.Size = new System.Drawing.Size(36, 26);
            btnFx.TabIndex = 6;
            btnFx.Text = "Fx";
            btnFx.UseVisualStyleBackColor = true;
            // 
            // ChannelControl
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(btnFx);
            Controls.Add(lblInfo);
            Controls.Add(lblMute);
            Controls.Add(lblSolo);
            Controls.Add(meter1);
            Controls.Add(panPan);
            Controls.Add(sldVolume);
            Name = "ChannelControl";
            Size = new System.Drawing.Size(339, 171);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Ephemera.NBagOfUis.Slider sldVolume;
        private Ephemera.NBagOfUis.Pan panPan;
        private Ephemera.NBagOfUis.Meter meter1;
        private System.Windows.Forms.Label lblSolo;
        private System.Windows.Forms.Label lblMute;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnFx;
        private System.Windows.Forms.ToolTip toolTip;
    }
}
