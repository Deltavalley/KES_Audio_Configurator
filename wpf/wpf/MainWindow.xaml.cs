using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public OpenFileDialog OfdAudio;
        const string imports = @"./imports";
        public MainWindow()
        {
            InitializeComponent();

            //create the OpenFileDialog
            OfdAudio = new OpenFileDialog
            {
                Filter = @"MP3 Files|*.mp3|All Files|*.*",
                Multiselect = true,
                Title = "Import Audio..."
            };

            //subscribe to the event
            OfdAudio.FileOk += OfdAudio_FileOk;
        }

        private void OfdAudio_FileOk(object? sender, CancelEventArgs e)
        {
            //create ./imports if it doesnt already exist
            if (!Directory.Exists(imports)) { Directory.CreateDirectory(imports); }

            //copy files to ./imports
            for (int i = 0; i < OfdAudio.FileNames.Length; i++)
            {
                //copy if the file isnt already there
                if (!File.Exists($"./{imports}/{OfdAudio.SafeFileNames[i]}"))
                {
                    File.Copy(OfdAudio.FileNames[i], $"./{imports}/{OfdAudio.SafeFileNames[i]}");
                }
            }

            //add the files to the list box 
            foreach (string fileName in OfdAudio.SafeFileNames)
            {
                AudioFile currentAudio = new(fileName, GetExtension(fileName));
                lstTracks.Items.Add(currentAudio);
            }
        }

        private string GetExtension(string fileName)
        {
            return fileName.Substring(fileName.LastIndexOf(".") + 1);
        }

        private void btnAddAudio_Click(object sender, RoutedEventArgs e)
        {
            OfdAudio.ShowDialog();
        }

        private async void lblGithub_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            //fires when the github textblock is clicked
            Clipboard.SetText(@"https://github.com/deltavalley/kes_audio_configurator");
            lblGithub.Foreground = new SolidColorBrush(System.Windows.Media.Color.FromArgb(255, 0, 150, 0));
            await Task.Delay(250);
            lblGithub.Foreground = new SolidColorBrush(System.Windows.Media.Color.FromArgb(255, 0, 0, 0));
        }

        private void btnAddPause_Click(object sender, RoutedEventArgs e)
        {
            lstTracks.Items.Add(new AudioFile()); //empty ctor --> pause
        }

        private void btnDuplicate_Click(object sender, RoutedEventArgs e)
        {
            lstTracks.Items.Add(lstTracks.SelectedItem);
        }

        private void btnRemove_Click(object sender, RoutedEventArgs e)
        {
            lstTracks.Items.Remove(lstTracks.SelectedItem);
        }

        private void btnRename_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtRename.Text)) { return; } //guard clause

            if (lstTracks.SelectedItem is AudioFile)
            {
                AudioFile file = (AudioFile)lstTracks.SelectedItem;
                file.DisplayName = txtRename.Text;
                txtRename.Text = "";

                //cause the listbox to update
                lstTracks.Items.Refresh();
            } else
            {
                throw new Exception($"Tried to rename an item in the list box that isnt an AudioFile{Common.errorEnd}");
            }
        }

        private void btnDeleteAll_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult r = MessageBox.Show($"Are you sure you want to clear the tracks?{Environment.NewLine}(This action can't be undone.)","Are you sure?",MessageBoxButton.YesNo,MessageBoxImage.Warning);
        
            if (r == MessageBoxResult.Yes)
            {
                lstTracks.Items.Clear();
            }
        }
    }
}
