using MoodPlaylist.SQLite.Data;
using MoodPlaylist.SQLite.Models;
using System.Collections.Generic;
using System.Linq;

namespace MoodPlaylist.SQLite.Services
{
    public class SongService
    {
        private readonly ApplicationDbContext _context;

        public SongService(ApplicationDbContext context)
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
