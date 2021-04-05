using System;
using System.Collections.Generic;

namespace kunstgalerij.DTO
{
    public class ArtworkAddDTO
    {
        //extra DTO classe made for getting the Id's of the artists and catogories
        public String Title { get; set; } 
        public int Year { get; set; }
        public int Price { get; set; }
        public string ImageEncoded { get; set; }
        public string Extension { get; set; }
        public string Imagename { get; set; }
        public int ArtistId { get; set; }
        public List<int> Categories { get; set; }
    }
}
