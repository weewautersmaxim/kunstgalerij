using System;
using System.Collections.Generic;

namespace kunstgalerij.DTO
{
    public class ArtworkAddDTO
    {
        public String Title { get; set; } 
        public int Year { get; set; }
        public int Price { get; set; }
        public int ArtistId { get; set; }
        public List<int> Categories { get; set; }
    }
}
