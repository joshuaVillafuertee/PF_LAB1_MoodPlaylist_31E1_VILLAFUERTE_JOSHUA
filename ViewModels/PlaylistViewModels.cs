using System;

namespace MoodPlaylist.Web.ViewModels
{
    public class PlaylistViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; }
        public string? MoodName { get; set; }
        public string? MoodColor { get; set; }
        public int SongCount { get; set; }
    }
}
