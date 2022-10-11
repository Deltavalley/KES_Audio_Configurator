using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Animation;

namespace wpf
{
    //forked commit
    public class AudioFile
    {
        static readonly Color pauseColor = Color.FromArgb(255, 150, 150, 150);

        public string DisplayName { get; set; }
        public string FileName { get; }
        public string FileExt { get; }
        public bool Renameable { get; }
        private Color DisplayColor { get; }
        private bool isForked;

        public SolidColorBrush DisplayBrush
        {
            get { return new SolidColorBrush(DisplayColor); }
        }


        //ctor
        public AudioFile(string displayName, string fileName, string fileExt, bool renameable, Color displayColor)
        {
            DisplayName = displayName;
            FileName = fileName;
            FileExt = fileExt;
            Renameable = renameable;
            DisplayColor = displayColor;
        }

        //ctor that assumes DisplayName = FileName
        public AudioFile(string fileName, string fileExt) : this(fileName, fileName, fileExt, true, Color.FromArgb(255,0,0,0)) { MessageBox.Show(isForked.ToString()); }

        //ctor w/ no args --> pause
        public AudioFile() : this("---PAUSE---", "", "", false,pauseColor) { }
    }

    public static class Common
    {
        public static string errorEnd = $"{Environment.NewLine}If you don't know what this means, contact senior tech team";
    }
}
