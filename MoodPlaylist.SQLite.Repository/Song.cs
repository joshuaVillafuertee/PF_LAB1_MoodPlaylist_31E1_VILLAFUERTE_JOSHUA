using MoodPlaylist.SQLite.Models;

public class Song
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Artist { get; set; } = string.Empty;
    public string Album { get; set; } = string.Empty;
    public string YouTubeUrl { get; set; } = string.Empty;

    public List<SongMood> SongMoods { get; set; } = new();
    public List<PlaylistSong> PlaylistSongs { get; set; } = new();
}
