using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using kunstgalerij.DataContext;
using kunstgalerij.Models;
using Microsoft.EntityFrameworkCore;

namespace kunstgalerij.Repositories
{
    public interface IArtworkRepository
    {
        Task<List<Artwork>> GetArtworks();
        Task<Artwork> AddArtwork(Artwork artwork);
        Task AddArtworkImage(Artwork artworkImage);
        Task<List<Artwork>> GetArtwork(int artistId);
    }

    public class ArtworkRepository : IArtworkRepository
    {
        private IArtContext _context;
        public ArtworkRepository(IArtContext context)
        {
            _context = context;
        }

        public async Task<List<Artwork>> GetArtworks()
        {
            return await _context.Artworks.Include(s => s.CategoryArtworks).ThenInclude(s => s.Category).Include(s => s.artist).ToListAsync();
        }

         public async Task<Artwork> AddArtwork(Artwork artwork)
        {
            await _context.Artworks.AddAsync(artwork);
            await _context.SaveChangesAsync();
            return artwork;
        }

        public async Task AddArtworkImage(Artwork artworkImage)
        {
            await _context.Artworks.AddAsync(artworkImage);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Artwork>> GetArtwork(int artistId)
        {
            return await _context.Artworks.Where(s => s.ArtistId == artistId).Include(s => s.CategoryArtworks).ThenInclude(s => s.Category).Include(s => s.artist).ToListAsync();
        }
    }
}
