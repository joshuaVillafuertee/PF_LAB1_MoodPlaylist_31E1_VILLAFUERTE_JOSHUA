using System.Collections.Generic;

namespace MoodPlaylist.Web.ViewModels
{
    public class DashboardViewModel
    {
        public List<PlaylistViewModel> Playlists { get; set; } = new();
        public List<SongViewModel> Songs { get; set; } = new();
    }
}
