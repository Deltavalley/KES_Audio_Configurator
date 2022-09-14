using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
            OfdAudio = new();
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
    }
}
