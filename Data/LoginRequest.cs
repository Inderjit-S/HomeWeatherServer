using System.ComponentModel.DataAnnotations;

namespace MusicServer.Data
{
    public class LoginRequest
    {
        public required string Username { get; set; }
        public required string Password { get; set; }
    }
}
