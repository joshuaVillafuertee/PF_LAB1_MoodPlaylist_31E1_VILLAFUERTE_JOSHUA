using Microsoft.AspNetCore.Mvc;
using MoodPlaylist.SQLite.Services;
using MoodPlaylist.Web.ViewModels;

namespace MoodPlaylist.Web.Controllers
{
    public class SongsController : Controller
    {
        private readonly SongService _songService;

        public SongsController(SongService songService)
        {
            _songService = songService;
        }

        public IActionResult Index()
        {
            var songs = _songService.GetAllSongs();
            var viewModel = songs.Select(s => new SongViewModel
            {
                Id = s.Id,
                Title = s.Title,
                Artist = s.Artist,
                Mood = s.Mood,
                YouTubeUrl = s.YouTubeUrl
            }).ToList();

            return View(viewModel);
        }
    }
}
