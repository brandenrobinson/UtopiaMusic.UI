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

        public ICollection<Artist> Artists { get; set; }

        public ICollection<Album> Albums { get; set; }
    }

    public class Artist
    {
        [Key]
        public int Id { get; set; }

        public ICollection<Track> Tracks { get; set; }

        public ICollection<Album> Albums { get; set; }
    }

    public class Album
    {
        [Key]
        public int Id { get; set; }

        public ICollection<Track> Tracks { get; set; }

        public ICollection<Artist> Artists { get; set; }
    }
}
