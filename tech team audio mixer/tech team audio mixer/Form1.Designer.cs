namespace tech_team_audio_mixer
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpTracks = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.lstTracks = new System.Windows.Forms.ListBox();
            this.grpOverview = new System.Windows.Forms.GroupBox();
            this.ofdImport = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblVolume = new System.Windows.Forms.Label();
            this.barVolime = new System.Windows.Forms.ProgressBar();
            this.grpTracks.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpTracks
            // 
            this.grpTracks.Controls.Add(this.button2);
            this.grpTracks.Controls.Add(this.button1);
            this.grpTracks.Controls.Add(this.btnImport);
            this.grpTracks.Controls.Add(this.lstTracks);
            this.grpTracks.Location = new System.Drawing.Point(12, 110);
            this.grpTracks.Name = "grpTracks";
            this.grpTracks.Size = new System.Drawing.Size(327, 328);
            this.grpTracks.TabIndex = 0;
            this.grpTracks.TabStop = false;
            this.grpTracks.Text = "Tracks";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(225, 80);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(225, 51);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Add Pause";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(225, 22);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(96, 23);
            this.btnImport.TabIndex = 2;
            this.btnImport.Text = "Add Track(s)...";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // lstTracks
            // 
            this.lstTracks.AllowDrop = true;
            this.lstTracks.FormattingEnabled = true;
            this.lstTracks.ItemHeight = 15;
            this.lstTracks.Location = new System.Drawing.Point(6, 22);
            this.lstTracks.Name = "lstTracks";
            this.lstTracks.Size = new System.Drawing.Size(213, 289);
            this.lstTracks.TabIndex = 1;
            this.lstTracks.DragDrop += new System.Windows.Forms.DragEventHandler(this.lstTracks_DragDrop);
            this.lstTracks.DragOver += new System.Windows.Forms.DragEventHandler(this.lstTracks_DragOver);
            this.lstTracks.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lstTracks_MouseDown);
            // 
            // grpOverview
            // 
            this.grpOverview.Location = new System.Drawing.Point(12, 12);
            this.grpOverview.Name = "grpOverview";
            this.grpOverview.Size = new System.Drawing.Size(776, 92);
            this.grpOverview.TabIndex = 2;
            this.grpOverview.TabStop = false;
            this.grpOverview.Text = "Overview";
            // 
            // ofdImport
            // 
            this.ofdImport.Filter = "MP3 Files|*.mp3|All Files|*.*";
            this.ofdImport.InitialDirectory = "./";
            this.ofdImport.Multiselect = true;
            this.ofdImport.Title = "Import Music...";
            this.ofdImport.FileOk += new System.ComponentModel.CancelEventHandler(this.ofdImport_FileOk);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblVolume);
            this.groupBox1.Controls.Add(this.barVolime);
            this.groupBox1.Location = new System.Drawing.Point(345, 110);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(443, 328);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Waveform and Levels";
            // 
            // lblVolume
            // 
            this.lblVolume.AutoSize = true;
            this.lblVolume.Location = new System.Drawing.Point(16, 301);
            this.lblVolume.Name = "lblVolume";
            this.lblVolume.Size = new System.Drawing.Size(38, 15);
            this.lblVolume.TabIndex = 1;
            this.lblVolume.Text = "XX db";
            // 
            // barVolime
            // 
            this.barVolime.Location = new System.Drawing.Point(74, 299);
            this.barVolime.Name = "barVolime";
            this.barVolime.Size = new System.Drawing.Size(363, 23);
            this.barVolime.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpOverview);
            this.Controls.Add(this.grpTracks);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpTracks.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox grpTracks;
        private ListBox lstTracks;
        private GroupBox grpOverview;
        private Button btnImport;
        private OpenFileDialog ofdImport;
        private GroupBox groupBox1;
        private ProgressBar barVolime;
        private Button button2;
        private Button button1;
        private Label lblVolume;
    }
}