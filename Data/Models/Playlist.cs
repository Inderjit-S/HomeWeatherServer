using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace MusicServer.Data.Models
{
    [Table("Playlists")]
    [Index(nameof(Name))]
    [Index(nameof(Creator))]
    public class Playlist
    {
        #region Properties

        [Key]
        [Required]
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public string Creator { get; set; } = null!;

        #endregion

        #region Navigation Properties

        public ICollection<Song>? Songs { get; set; } = null!;

        #endregion
    }
}
