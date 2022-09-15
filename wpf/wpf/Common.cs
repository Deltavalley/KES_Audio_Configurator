using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wpf
{
    public class AudioFile
    {
        public string DisplayName { get; set; }
        public string FileName { get; }
        public string FileExt { get; }
        public bool Renameable { get; }
        public Color DisplayColor { get; }

        //ctor
        public AudioFile(string displayName, string fileName, string fileExt, bool renameable, Color displayColor)
        {
            DisplayName = displayName;
            FileName = fileName;
            FileExt = fileExt;
            Renameable = renameable;
        }

        //ctor that assumes DisplayName = FileName
        public AudioFile(string fileName, string fileExt) : this(fileName, fileName, fileExt, true, Color.Black) { }

        //ctor w/ no args --> pause
        public AudioFile() : this("---PAUSE---", "", "", false,Color.Gray) { }
    }

    public static class Common
    {
        public static string errorEnd = $"{Environment.NewLine}If you don't know what this means, contact senior tech team";
    }
}
