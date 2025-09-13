using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MoodPlaylist.SQLite.Models
{
    public class Playlist
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        public int? MoodId { get; set; }
        public Mood? Mood { get; set; }

        public int UserId { get; set; }
        public User User { get; set; } = null!;

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public List<PlaylistSong> PlaylistSongs { get; set; } = new();
    }
}
