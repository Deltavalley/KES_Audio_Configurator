using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NAudio.Wave;

namespace tech_team_audio_mixer
{
    public class AudioFile
    {
        public string DisplayName { get; set; }
        public string FileName { get; }
        public string FileExt { get; }

        public AudioFile(string displayName, string fileName, string fileExt)
        {
            DisplayName = displayName;
            FileName = fileName;
            FileExt = fileExt;
        }

        public AudioFile(string fileName, string fileExt) : this(fileName, fileName, fileExt) { }
    }

    public class Common
    {

    }
}
