using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.Metrics;
namespace MusicServer.Data.Models
{
    [Table("Songs")]
    [Index(nameof(Title))]
    [Index(nameof(Artist))]
    [Index(nameof(Genre))]
    public class Song
    {
        #region Properties
        [Key]
        [Required]
        public int SongId { get; set; }

        public string Title { get; set; } = null!;

        public string Artist { get; set; } = null!;

        public string Genre { get; set; } = null!;

        //[ForeignKey(nameof(Playlist))]
        [ForeignKey("playlistId")]

        public int PlaylistId { get; set; }

        #endregion

        #region Navigation Properties

        public Playlist? Playlist { get; set; } = null!;

        #endregion
    }
}
