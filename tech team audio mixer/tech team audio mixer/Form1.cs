using System.CodeDom;

namespace tech_team_audio_mixer
{
    public partial class Form1 : Form
    {
        const string imports = @"./imports"; //location of imported audio

        public Form1() //ctor
        {
            InitializeComponent();

            //list box will display the property named "DisplayName" as the text for objects in the ListBox.Items list
            lstTracks.ValueMember = "DisplayName";
        }

        private void lstTracks_MouseDown(object sender, MouseEventArgs e)
        {
            if (this.lstTracks.SelectedItem == null) { return; }
            this.lstTracks.DoDragDrop(this.lstTracks.SelectedItem, DragDropEffects.Move);
        }

        private void lstTracks_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void lstTracks_DragDrop(object sender, DragEventArgs e)
        {
            //get coords of cursor and convert to an index in list box
            Point p = this.lstTracks.PointToClient(new Point(e.X, e.Y));
            int index = this.lstTracks.IndexFromPoint(p);

            if (index < 0) { index = this.lstTracks.Items.Count - 1; }
            object data = lstTracks.SelectedItem;

            //update the list box
            this.lstTracks.Items.Remove(data);
            this.lstTracks.Items.Insert(index, data);

        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            ofdImport.ShowDialog();
        }

        //Occurs when the user clicks on the Open or Save button on a file dialog box.
        private void ofdImport_FileOk(object sender, System.ComponentModel.CancelEventArgs e) 
        {
            //create ./imports if it doesnt already exist
            if (!Directory.Exists(imports)) { Directory.CreateDirectory(imports); }

            //copy files to ./imports
            for (int i = 0; i < ofdImport.FileNames.Length; i++)
            {
                //copy if the file isnt already there
                if (!File.Exists($"./{imports}/{ofdImport.SafeFileNames[i]}"))
                {
                    File.Copy(ofdImport.FileNames[i], $"./{imports}/{ofdImport.SafeFileNames[i]}");
                } 
            }

            //add the files to the list box 
            foreach (string fileName in ofdImport.SafeFileNames)
            {
                AudioFile currentAudio = new(fileName, GetExtension(fileName));
                lstTracks.Items.Add(currentAudio);
            }
        }

        private string GetExtension(string fileName)
        {
            return fileName.Substring(fileName.LastIndexOf(".") + 1);
        }

        private void btnDelAll_Click(object sender, EventArgs e)
        {
            //are you sure?
            DialogResult r = MessageBox.Show("Are you sure you want to clear the audio list?" + Environment.NewLine + "(This action cannot be undone)", "Are you sure?", MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            
            if (r == DialogResult.Yes)
            {
                //delete the contents of the list box
                lstTracks.Items.Clear();
            }
            else
            {
                //nothing
            }
        }

        private void btnDuplicate_Click(object sender, EventArgs e)
        {
            if (lstTracks.SelectedItem != null)
            {
                lstTracks.Items.Add(lstTracks.SelectedItem);
            }
        }

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            if (lstTracks.SelectedItem != null)
            {
                lstTracks.Items.Remove(lstTracks.SelectedItem);
            }
        }

        private async void stripLabelSourceCode_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("https://github.com/Deltavalley/KES_Audio_Configurator");

            stripLabelSourceCode.ForeColor = Color.FromArgb(255, 0, 100, 0);
            await Task.Delay(250);
            stripLabelSourceCode.ForeColor = Color.FromArgb(255, 0, 0, 0);
        }

        private void btnAddPause_Click(object sender, EventArgs e)
        {
            lstTracks.Items.Add(new AudioPause());
        }

        private void btnRename_Click(object sender, EventArgs e)
        {
            if (lstTracks.SelectedItem != null && !string.IsNullOrEmpty(txtRename.Text))
            {
                //we are only ever putting objects that implement IListBoxable into the list box
                IListBoxable? selectedItem = lstTracks.SelectedItem as IListBoxable;
                if (selectedItem == null)
                {
                    throw new Exception($"Selected item does not implement IListBoxable{Common.errorEnd}");
                } else
                {
                    //check we can change this entry in the list
                    if (selectedItem.renameable)
                    {
                        selectedItem.DisplayName = txtRename.Text;
                        txtRename.Text = "";
                    }
                }
            }
        }
    }
}