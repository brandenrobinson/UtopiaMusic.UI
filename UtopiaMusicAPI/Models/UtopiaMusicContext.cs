using Microsoft.EntityFrameworkCore;

namespace UtopiaMusicAPI.Models
{
    public class UtopiaMusicContext : DbContext
    {
        public DbSet<Track> Tracks { get; set; }

        public DbSet<Artist> Artists { get; set; }

        public DbSet<Album> Albums { get; set; }

        public UtopiaMusicContext(DbContextOptions<UtopiaMusicContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TrackArtist>()
                .HasKey(tar => new { tar.TrackId, tar.ArtistId });
            modelBuilder.Entity<TrackArtist>()
                .HasOne(tar => tar.Track)
                .WithMany(t => t.TrackArtists)
                .HasForeignKey(tar => tar.TrackId);
            modelBuilder.Entity<TrackArtist>()
                .HasOne(tar => tar.Artist)
                .WithMany(ar => ar.ArtistTracks)
                .HasForeignKey(tar => tar.ArtistId);

            modelBuilder.Entity<TrackAlbum>()
                .HasKey(tal => new { tal.TrackId, tal.AlbumId });
            modelBuilder.Entity<TrackAlbum>()
                .HasOne(tal => tal.Track)
                .WithMany(t => t.TrackAlbums)
                .HasForeignKey(tal => tal.TrackId);
            modelBuilder.Entity<TrackAlbum>()
                .HasOne(tal => tal.Album)
                .WithMany(al => al.AlbumTracks)
                .HasForeignKey(tal => tal.AlbumId);

            modelBuilder.Entity<AlbumArtist>()
                .HasKey(alar => new { alar.AlbumId, alar.ArtistId });
            modelBuilder.Entity<AlbumArtist>()
                .HasOne(alar => alar.Album)
                .WithMany(alar => alar.AlbumArtists)
                .HasForeignKey(alar => alar.AlbumId);
            modelBuilder.Entity<AlbumArtist>()
                .HasOne(alar => alar.Artist)
                .WithMany(alar => alar.ArtistAlbums)
                .HasForeignKey(alar => alar.ArtistId);
        }
    }
}
