using System.CodeDom;

namespace tech_team_audio_mixer
{
    public partial class Form1 : Form
    {
        public Form1() //ctor
        {
            InitializeComponent();
            lstTracks.ValueMember = "DisplayName";
        }

        private void lstTracks_MouseDown(object sender, MouseEventArgs e)
        {
            if (this.lstTracks.SelectedItem == null) { return; }
            this.lstTracks.DoDragDrop(this.lstTracks.SelectedItem, DragDropEffects.All);
        }

        private void lstTracks_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void lstTracks_DragDrop(object sender, DragEventArgs e)
        {
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

        private void ofdImport_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }
    }
}