using MoodPlaylist.SQLite.Models;

namespace MoodPlaylist.SQLite.Services
{
    public interface IAuthService
    {
        User? Authenticate(string username, string password);
        User Register(string username, string password);
    }
}
