using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using kunstgalerij.DataContext;
using kunstgalerij.Models;
using Microsoft.EntityFrameworkCore;

namespace kunstgalerij.Repositories
{
    public interface IArtworkRepository
    {
        Task<List<Artwork>> GetArtwork();
        Task<Artwork> AddArtwork(Artwork artwork);
        Task AddArtworkImage(ArtworkImage artworkImage);
    }

    public class ArtworkRepository : IArtworkRepository
    {
        private IArtContext _context;
        public ArtworkRepository(IArtContext context)
        {
            _context = context;
        }

        public async Task<List<Artwork>> GetArtwork()
        {
            return await _context.Artworks.Include(s => s.CategoryArtworks).ThenInclude(s => s.Category).Include(s => s.artist).ToListAsync();
        }

         public async Task<Artwork> AddArtwork(Artwork artwork)
        {
            await _context.Artworks.AddAsync(artwork);
            await _context.SaveChangesAsync();
            return artwork;
        }

        public async Task AddArtworkImage(ArtworkImage artworkImage)
        {
            await _context.ArtworkImages.AddAsync(artworkImage);
            await _context.SaveChangesAsync();
        }
    }
}
