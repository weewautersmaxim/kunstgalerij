using System;

namespace kunstgalerij.Models
{
    public class Artist
    {
        public Guid ArtistId { get; set; }
        public String Name { get; set; }
        public String FirstName { get; set; }
        public int Age { get; set; }
        public String Gender { get; set; }
        public String Birthplace { get; set; }
        public String description { get; set; }

    }
}
