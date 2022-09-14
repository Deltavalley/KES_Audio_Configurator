namespace tech_team_audio_mixer
{
    public class AudioFile
    {
        public string DisplayName { get; set; }
        public string FileName { get; }
        public string FileExt { get; }
        public bool Renameable { get; }

        //ctor
        public AudioFile(string displayName, string fileName, string fileExt, bool renameable)
        {
            DisplayName = displayName;
            FileName = fileName;
            FileExt = fileExt;
            Renameable = renameable;
        }

        //ctor that assumes DisplayName = FileName
        public AudioFile(string fileName, string fileExt) : this(fileName, fileName, fileExt, true) { }

        //ctor w/ no args --> pause
        public AudioFile() : this("---PAUSE---", "", "", false) { }
    }

    public static class Common
    {
        public static string errorEnd = $"{Environment.NewLine}If you don't know what this means, contact senior tech team";
    }
}
