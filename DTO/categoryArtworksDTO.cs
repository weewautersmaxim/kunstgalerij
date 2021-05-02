namespace kunstgalerij.DTO
{
    public class CategoryArtworksDTO
    {
        //this DTO is (like artworkArtistDTO) a extra DTO to filter another module 
        public int CategoryId { get; set; }    
        public CategoryDTO Category { get; set; }

    }
}
