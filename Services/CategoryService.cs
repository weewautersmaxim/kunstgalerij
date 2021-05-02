using System.Collections.Generic;
using System.Threading.Tasks;
using kunstgalerij.Models;
using kunstgalerij.Repositories;

namespace kunstgalerij.Services
{
    public interface ICategoryService
    {
        Task<List<Category>> GetCategory();
    }

    public class CategoryService : ICategoryService
    {
        private ICategoryRepository _CategoryRepository;
        public CategoryService(ICategoryRepository categoryRepository)
        {
            _CategoryRepository = categoryRepository;
        }
        public async Task<List<Category>> GetCategory()
        {
            return await _CategoryRepository.GetCategory();
        }
    }
}
