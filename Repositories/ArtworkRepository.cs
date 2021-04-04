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
            return await _context.Artworks.Include(s => s.artist).ToListAsync();
        }
    }
}
