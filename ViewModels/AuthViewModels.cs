using System.ComponentModel.DataAnnotations;

namespace MoodPlaylist.Web.ViewModels
{
    public class AuthViewModel
    {
        [Required]
        public string Username { get; set; } = string.Empty;

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; } = string.Empty;
    }
}
