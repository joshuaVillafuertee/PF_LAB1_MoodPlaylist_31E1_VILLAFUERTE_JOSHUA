using Microsoft.EntityFrameworkCore;
using MoodPlaylist.SQLite.Data;
using MoodPlaylist.SQLite.Models; 
using System.Collections.Generic;
using System.Linq;

namespace MoodPlaylist.SQLite.Services
{
    public class PlaylistService
    {
        private readonly ApplicationDbContext _context;

        public PlaylistService(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<Playlist> GetAllPlaylists()
        {
            return _context.Playlists
                .Include(p => p.Mood)          
                .Include(p => p.PlaylistSongs) 
                .ToList();
        }
    }
}
