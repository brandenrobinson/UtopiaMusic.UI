using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace UtopiaMusicAPI.Models
{
    public class Track
    {
        [Key]
        public int Id { get; set; }

        public int? InitialAlbumId { get; set; }

        public bool IsOnYouTube { get; set; }

        public bool IsOnSoundcloud { get; set; }

        public bool CanBePurchased { get; set; }

        public string TrackName { get; set; }

        public ICollection<TrackArtist> TrackArtists { get; set; }

        public ICollection<TrackAlbum> TrackAlbums { get; set; }
    }

    public class Artist
    {
        [Key]
        public int ArtistId { get; set; }

        public ICollection<TrackArtist> ArtistTracks { get; set; }

        public ICollection<AlbumArtist> ArtistAlbums { get; set; }
    }

    public class Album
    {
        [Key]
        public int AlbumId { get; set; }

        public ICollection<TrackAlbum> AlbumTracks { get; set; }

        public ICollection<AlbumArtist> AlbumArtists { get; set; }
    }

    public class TrackArtist
    {
        public int TrackId { get; set; }

        public Track Track { get; set; }

        public int ArtistId { get; set; }

        public Artist Artist { get; set; }
    }

    public class TrackAlbum
    {
        public int TrackId { get; set; }

        public Track Track { get; set; }

        public int AlbumId { get; set; }

        public Album Album { get; set; }
    }

    public class AlbumArtist
    {
        public int ArtistId { get; set; }

        public Artist Artist { get; set; }

        public int AlbumId { get; set; }

        public Album Album { get; set; }
    }
}
