using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using kunstgalerij.DataContext;
using kunstgalerij.Models;
using Microsoft.EntityFrameworkCore;

namespace kunstgalerij.Repositories
{
    public interface ICategoryRepository
    {
        Task<List<Category>> GetCategory();
    }

    public class CategoryRepository : ICategoryRepository
    {
        private IArtContext _context;
        public CategoryRepository(IArtContext context)
        {
            _context = context;
        }
        public async Task<List<Category>> GetCategory()
        {
            return await _context.Categories.ToListAsync();
        }

    }
}
