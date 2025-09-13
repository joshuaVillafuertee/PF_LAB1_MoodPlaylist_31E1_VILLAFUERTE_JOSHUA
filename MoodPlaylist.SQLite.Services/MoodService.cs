using MoodPlaylist.SQLite.Data;
using MoodPlaylist.SQLite.Models;
using System.Collections.Generic;
using System.Linq;

namespace MoodPlaylist.SQLite.Services
{
    public class MoodService
    {
        private readonly ApplicationDbContext _context;

        public MoodService(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Mood> GetAllMoods() => _context.Moods.ToList();

        public Mood? GetMoodById(int id) => _context.Moods.FirstOrDefault(m => m.Id == id);

        public void AddMood(Mood mood)
        {
            _context.Moods.Add(mood);
            _context.SaveChanges();
        }

        public void DeleteMood(int id)
        {
            var mood = _context.Moods.FirstOrDefault(m => m.Id == id);
            if (mood != null)
            {
                _context.Moods.Remove(mood);
                _context.SaveChanges();
            }
        }
    }
}
