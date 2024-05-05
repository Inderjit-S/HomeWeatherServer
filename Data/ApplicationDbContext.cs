using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Metrics;
using MusicServer.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
namespace MusicServer.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() : base()
        {
        }
        public ApplicationDbContext(DbContextOptions options)
         : base(options)
        {
        }
        public DbSet<Song> Songs => Set<Song>();
        public DbSet<Playlist> Playlists => Set<Playlist>();
    }
}
