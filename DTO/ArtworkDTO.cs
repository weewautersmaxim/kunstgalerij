using System;
using System.Collections.Generic;

namespace kunstgalerij.DTO
{
    public class ArtworkDTO
    {
        public String Title { get; set; } 
        public int Year { get; set; }
        public int Price { get; set; }

        public ArtworkArtistDTO artist { get; set; }
        public ArtworkAddDTO Category { get; set; }
    }
}