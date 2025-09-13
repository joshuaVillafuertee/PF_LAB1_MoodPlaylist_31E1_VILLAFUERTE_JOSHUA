using System.ComponentModel.DataAnnotations;

namespace MoodPlaylist.SQLite.Repository.Models
{
    public class Song
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; } = string.Empty;

        [Required]
        public string Artist { get; set; } = string.Empty;

        [Required]
        [Url]
        public string YouTubeUrl { get; set; } = string.Empty;

        [Required]
        public string Mood { get; set; } = string.Empty;  

        public int UserId { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        
        public User User { get; set; } = null!;
        public List<SongMood> SongMoods { get; set; } = new();
        public List<PlaylistSong> PlaylistSongs { get; set; } = new();
    }
}

namespace MoodPlaylist.SQLite.Repository.Models
{
    public class SongMood
    {
        public int SongId { get; set; }
        public int MoodId { get; set; }
        
        // Navigation properties
        public Song Song { get; set; } = null!;
        public Mood Mood { get; set; } = null!;
    }
}

using MoodPlaylist.SQLite.Models;
using MoodPlaylistGenerator.Data;
using MoodPlaylistGenerator.Models;
using System.Collections.Generic;
using System.Linq;

namespace MoodPlaylist.SQLite.Repository.Models
{
    public class SongRepository
    {
        private readonly ApplicationDbContext _context;

        public SongRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Song> GetAllSongs()
        {
            return _context.Songs.ToList();
        }

        public Song? GetSongById(int id)
        {
            return _context.Songs.FirstOrDefault(s => s.Id == id);
        }

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


using System.ComponentModel.DataAnnotations;

namespace MoodPlaylist.SQLite.Repository.Models
{
    public class Song
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; } = string.Empty;

        [Required]
        public string Artist { get; set; } = string.Empty;

        [Required]
        [Url]
        public string YouTubeUrl { get; set; } = string.Empty;

        [Required]
        public string Mood { get; set; } = string.Empty;  

        public int UserId { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        
        public User User { get; set; } = null!;
        public List<SongMood> SongMoods { get; set; } = new();
        public List<PlaylistSong> PlaylistSongs { get; set; } = new();
    }
}

namespace MoodPlaylist.SQLite.Repository.Models
{
    public class SongMood
    {
        public int SongId { get; set; }
        public int MoodId { get; set; }
        
        // Navigation properties
        public Song Song { get; set; } = null!;
        public Mood Mood { get; set; } = null!;
    }
}

using MoodPlaylist.SQLite.Models;
using MoodPlaylistGenerator.Data;
using MoodPlaylistGenerator.Models;
using System.Collections.Generic;
using System.Linq;

namespace MoodPlaylist.SQLite.Repository.Models
{
    public class SongRepository
    {
        private readonly ApplicationDbContext _context;

        public SongRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Song> GetAllSongs()
        {
            return _context.Songs.ToList();
        }

        public Song? GetSongById(int id)
        {
            return _context.Songs.FirstOrDefault(s => s.Id == id);
        }

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


