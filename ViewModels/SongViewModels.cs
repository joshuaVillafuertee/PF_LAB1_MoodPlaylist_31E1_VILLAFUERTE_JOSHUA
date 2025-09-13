namespace MoodPlaylist.Web.ViewModels
{
    public class SongViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Artist { get; set; } = string.Empty;
        public string Mood { get; set; } = string.Empty;
        public string YouTubeUrl { get; set; } = string.Empty;
    }
}
