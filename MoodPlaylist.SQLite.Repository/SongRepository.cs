using MoodPlaylist.SQLite.Models;
using MoodPlaylist.SQLite.Data; // <-- make sure this is correct where ApplicationDbContext lives
using System.Collections.Generic;
using System.Linq;

namespace MoodPlaylist.SQLite.Repository
{
    public class SongRepository
    {
        private readonly ApplicationDbContext _context;

        public SongRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Song> GetAllSongs() => _context.Songs.ToList();

        public Song? GetSongById(int id) => _context.Songs.FirstOrDefault(s => s.Id == id);

        public void AddSong(Song song)
        {
            _context.Songs.Add(song);
            _context.SaveChanges();
        }

        public void DeleteSong(int id)
        {
            var song = _context.Songs.FirstOrDefault(s => s.Id == id);
            if (song != null)
            {
                _context.Songs.Remove(song);
                _context.SaveChanges();
            }
        }
    }
}
