using MoodPlaylist.SQLite.Models;
using MoodPlaylist.SQLite.Repository;
using MoodPlaylistGenerator.Models;
using System.Collections.Generic;
using System.Linq;

namespace MoodPlaylist.SQLite.Services
{
    public class MoodService
    {
        private readonly SongRepository _songRepository;

        public MoodService(SongRepository songRepository)
        {
            _songRepository = songRepository;
        }

        public IEnumerable<Song> GetSongsByMood(string mood)
        {
            return _songRepository
                   .GetAllSongs()
                   .Where(s => s.Mood.Equals(mood, System.StringComparison.OrdinalIgnoreCase));
        }
    }
}
