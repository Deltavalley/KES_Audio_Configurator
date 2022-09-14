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
            this.btnRename = new System.Windows.Forms.Button();
            this.txtRename = new System.Windows.Forms.TextBox();
            this.btnDuplicate = new System.Windows.Forms.Button();
            this.btnDelAll = new System.Windows.Forms.Button();
            this.btnRemoveItem = new System.Windows.Forms.Button();
            this.btnAddPause = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.lstTracks = new System.Windows.Forms.ListBox();
            this.grpOverview = new System.Windows.Forms.GroupBox();
            this.ofdImport = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblVolume = new System.Windows.Forms.Label();
            this.barVolime = new System.Windows.Forms.ProgressBar();
            this.strip = new System.Windows.Forms.StatusStrip();
            this.stripLabelDeltavalley = new System.Windows.Forms.ToolStripStatusLabel();
            this.stripLabelSourceCode = new System.Windows.Forms.ToolStripStatusLabel();
            this.grpTracks.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.strip.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpTracks
            // 
            this.grpTracks.Controls.Add(this.btnRename);
            this.grpTracks.Controls.Add(this.txtRename);
            this.grpTracks.Controls.Add(this.btnDuplicate);
            this.grpTracks.Controls.Add(this.btnDelAll);
            this.grpTracks.Controls.Add(this.btnRemoveItem);
            this.grpTracks.Controls.Add(this.btnAddPause);
            this.grpTracks.Controls.Add(this.btnImport);
            this.grpTracks.Controls.Add(this.lstTracks);
            this.grpTracks.Location = new System.Drawing.Point(12, 110);
            this.grpTracks.Name = "grpTracks";
            this.grpTracks.Size = new System.Drawing.Size(357, 331);
            this.grpTracks.TabIndex = 0;
            this.grpTracks.TabStop = false;
            this.grpTracks.Text = "Tracks";
            // 
            // btnRename
            // 
            this.btnRename.Location = new System.Drawing.Point(225, 179);
            this.btnRename.Name = "btnRename";
            this.btnRename.Size = new System.Drawing.Size(126, 23);
            this.btnRename.TabIndex = 7;
            this.btnRename.Text = "Rename Item";
            this.btnRename.UseVisualStyleBackColor = true;
            this.btnRename.Click += new System.EventHandler(this.btnRename_Click);
            // 
            // txtRename
            // 
            this.txtRename.Location = new System.Drawing.Point(225, 150);
            this.txtRename.Name = "txtRename";
            this.txtRename.Size = new System.Drawing.Size(126, 23);
            this.txtRename.TabIndex = 6;
            // 
            // btnDuplicate
            // 
            this.btnDuplicate.Location = new System.Drawing.Point(225, 80);
            this.btnDuplicate.Name = "btnDuplicate";
            this.btnDuplicate.Size = new System.Drawing.Size(126, 23);
            this.btnDuplicate.TabIndex = 5;
            this.btnDuplicate.Text = "Duplicate Item";
            this.btnDuplicate.UseVisualStyleBackColor = true;
            this.btnDuplicate.Click += new System.EventHandler(this.btnDuplicate_Click);
            // 
            // btnDelAll
            // 
            this.btnDelAll.Location = new System.Drawing.Point(225, 302);
            this.btnDelAll.Name = "btnDelAll";
            this.btnDelAll.Size = new System.Drawing.Size(126, 23);
            this.btnDelAll.TabIndex = 4;
            this.btnDelAll.Text = "Delete All";
            this.btnDelAll.UseVisualStyleBackColor = true;
            this.btnDelAll.Click += new System.EventHandler(this.btnDelAll_Click);
            // 
            // btnRemoveItem
            // 
            this.btnRemoveItem.Location = new System.Drawing.Point(225, 109);
            this.btnRemoveItem.Name = "btnRemoveItem";
            this.btnRemoveItem.Size = new System.Drawing.Size(126, 23);
            this.btnRemoveItem.TabIndex = 3;
            this.btnRemoveItem.Text = "Remove Item";
            this.btnRemoveItem.UseVisualStyleBackColor = true;
            this.btnRemoveItem.Click += new System.EventHandler(this.btnRemoveItem_Click);
            // 
            // btnAddPause
            // 
            this.btnAddPause.Location = new System.Drawing.Point(225, 51);
            this.btnAddPause.Name = "btnAddPause";
            this.btnAddPause.Size = new System.Drawing.Size(126, 23);
            this.btnAddPause.TabIndex = 2;
            this.btnAddPause.Text = "Add Pause";
            this.btnAddPause.UseVisualStyleBackColor = true;
            this.btnAddPause.Click += new System.EventHandler(this.btnAddPause_Click);
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(225, 22);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(126, 23);
            this.btnImport.TabIndex = 2;
            this.btnImport.Text = "Add Audio...";
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
            this.groupBox1.Location = new System.Drawing.Point(375, 110);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(413, 331);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Waveform and Levels";
            // 
            // lblVolume
            // 
            this.lblVolume.AutoSize = true;
            this.lblVolume.Location = new System.Drawing.Point(21, 302);
            this.lblVolume.Name = "lblVolume";
            this.lblVolume.Size = new System.Drawing.Size(38, 15);
            this.lblVolume.TabIndex = 1;
            this.lblVolume.Text = "XX db";
            // 
            // barVolime
            // 
            this.barVolime.Location = new System.Drawing.Point(74, 299);
            this.barVolime.Name = "barVolime";
            this.barVolime.Size = new System.Drawing.Size(333, 23);
            this.barVolime.TabIndex = 0;
            // 
            // strip
            // 
            this.strip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stripLabelDeltavalley,
            this.stripLabelSourceCode});
            this.strip.Location = new System.Drawing.Point(0, 443);
            this.strip.Name = "strip";
            this.strip.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.strip.Size = new System.Drawing.Size(800, 22);
            this.strip.TabIndex = 4;
            this.strip.Text = "statusStrip1";
            // 
            // stripLabelDeltavalley
            // 
            this.stripLabelDeltavalley.Image = global::tech_team_audio_mixer.Properties.Resources.deltavalley_profile_pic;
            this.stripLabelDeltavalley.Margin = new System.Windows.Forms.Padding(5, 3, 0, 2);
            this.stripLabelDeltavalley.Name = "stripLabelDeltavalley";
            this.stripLabelDeltavalley.Size = new System.Drawing.Size(96, 17);
            this.stripLabelDeltavalley.Text = "By Deltavalley";
            // 
            // stripLabelSourceCode
            // 
            this.stripLabelSourceCode.Image = global::tech_team_audio_mixer.Properties.Resources.github;
            this.stripLabelSourceCode.Margin = new System.Windows.Forms.Padding(10, 3, 0, 2);
            this.stripLabelSourceCode.Name = "stripLabelSourceCode";
            this.stripLabelSourceCode.Size = new System.Drawing.Size(144, 17);
            this.stripLabelSourceCode.Text = "github.com (copy link)";
            this.stripLabelSourceCode.Click += new System.EventHandler(this.stripLabelSourceCode_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 465);
            this.Controls.Add(this.strip);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpOverview);
            this.Controls.Add(this.grpTracks);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpTracks.ResumeLayout(false);
            this.grpTracks.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.strip.ResumeLayout(false);
            this.strip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox grpTracks;
        private ListBox lstTracks;
        private GroupBox grpOverview;
        private Button btnImport;
        private OpenFileDialog ofdImport;
        private GroupBox groupBox1;
        private ProgressBar barVolime;
        private Button btnRemoveItem;
        private Button btnAddPause;
        private Label lblVolume;
        private Button btnDelAll;
        private Button btnDuplicate;
        private StatusStrip strip;
        private ToolStripStatusLabel stripLabelDeltavalley;
        private ToolStripStatusLabel stripLabelSourceCode;
        private Button btnRename;
        private TextBox txtRename;
    }
}