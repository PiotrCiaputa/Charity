using Charity.Mvc.Data;
using Charity.Mvc.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Charity.Mvc.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly AppDbContext _context;

        public CategoryService(AppDbContext context)
        {
            _context = context;
        }

        public List<Category> GetAllCategories()
        {
            return _context.Categories.OrderBy(x => x.Id).ToList();
        }

        public void AddCategory(Category category)
        {
            _context.Categories.Add(category);
        }        

        public Category GetCategory(int? id)
        {
            return _context.Categories.FirstOrDefault(x => x.Id == id);
        }
        public void UpdateCategory(Category category)
        {
            _context.Categories.Update(category);
        }

        public void RemoveCategory(int id)
        {
            _context.Categories.Remove(GetCategory(id));
        }

        public async Task<bool> SaveChangesAsync()
        {
            if (await _context.SaveChangesAsync() > 0)
            {
                return true;
            }

            return false;
        }        
    }
}
