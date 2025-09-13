using Microsoft.AspNetCore.Mvc;
using MoodPlaylist.SQLite.Services;
using MoodPlaylist.Web.ViewModels;
using System.Linq;

namespace MoodPlaylist.Web.Controllers
{
    public class PlaylistsController : Controller
    {
        private readonly PlaylistService _playlistService;
        private readonly MoodService _moodService; // ✅ add MoodService so we can load moods

        public PlaylistsController(PlaylistService playlistService, MoodService moodService)
        {
            _playlistService = playlistService;
            _moodService = moodService;
        }

        public IActionResult Index(int? moodId)
        {
            var playlists = _playlistService.GetAllPlaylists();

            // ✅ filter playlists by mood if a filter is applied
            if (moodId.HasValue)
            {
                playlists = playlists.Where(p => p.MoodId == moodId.Value).ToList();
            }

            var viewModel = new PlaylistListViewModel
            {
                Playlists = playlists.Select(p => new PlaylistViewModel
                {
                    Id = p.Id,
                    Name = p.Name,
                    CreatedAt = p.CreatedAt,
                    MoodName = p.Mood?.Name,
                    MoodColor = p.Mood?.Color,
                    SongCount = p.PlaylistSongs?.Count ?? 0
                }).ToList(),
                Moods = _moodService.GetAllMoods().ToList(),
                FilterMoodId = moodId
            };

            return View(viewModel);
        }
    }
}
