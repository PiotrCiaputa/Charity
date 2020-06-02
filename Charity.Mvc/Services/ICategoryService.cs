using Charity.Mvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Charity.Mvc.Services
{
    public interface ICategoryService
    {
        List<Category> GetAllCategories();
        void AddCategory(Category category);
        Category GetCategory(int? id);
        void UpdateCategory(Category category);
        void RemoveCategory(int id);

        Task<bool> SaveChangesAsync();
    }
}
