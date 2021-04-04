using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using kunstgalerij.DataContext;
using kunstgalerij.Models;
using Microsoft.EntityFrameworkCore;

namespace kunstgalerij.Repositories
{
    public interface IArtistRepository
    {
        Task<List<Artist>> GetArtist();
    }

    public class ArtistRepository : IArtistRepository
    {
        private IArtContext _context;
        public ArtistRepository(IArtContext context)
        {
            _context = context;
        }

        public async Task<List<Artist>> GetArtist()
        {
            return await _context.Artists.ToListAsync();
        }

    }
}
