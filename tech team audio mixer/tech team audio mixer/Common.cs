namespace tech_team_audio_mixer
{
    public interface IListBoxable
    {
        public string DisplayName { get; set; }
        public bool renameable { get; }
    }

    public class AudioFile : IListBoxable
    {
        public string DisplayName { get; set; }
        public string FileName { get; }
        public string FileExt { get; }
        public bool renameable { get => true; }

        public AudioFile(string displayName, string fileName, string fileExt)
        {
            DisplayName = displayName;
            FileName = fileName;
            FileExt = fileExt;
        }

        public AudioFile(string fileName, string fileExt) : this(fileName, fileName, fileExt) { }
    }

    public class AudioPause : IListBoxable
    {
        public string DisplayName { get => "---PAUSE---"; set => throw new Exception($"Tried to change name of a pause{Common.errorEnd}"); }
        public bool renameable { get => true; }
    }

    public static class Common
    {
        public static string errorEnd = $"{Environment.NewLine}If you don't know what this means, contact senior tech team";
    }
}
