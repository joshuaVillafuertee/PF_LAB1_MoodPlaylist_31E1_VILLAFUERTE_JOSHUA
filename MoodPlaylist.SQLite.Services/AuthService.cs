using MoodPlaylist.SQLite.Data;
using MoodPlaylist.SQLite.Models;
using System.Linq;

namespace MoodPlaylist.SQLite.Services
{
    public class AuthService : IAuthService
    {
        private readonly ApplicationDbContext _context;

        public AuthService(ApplicationDbContext context)
        {
            _context = context;
        }

        public User? Authenticate(string username, string password)
        {
            return _context.Users.FirstOrDefault(u => u.Username == username);
            // ⚠️ Replace this with proper password hashing in a real app
        }

        public User Register(string username, string password)
        {
            var user = new User { Username = username };
            _context.Users.Add(user);
            _context.SaveChanges();
            return user;
        }
    }
}
