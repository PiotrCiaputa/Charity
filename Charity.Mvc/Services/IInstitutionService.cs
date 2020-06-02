using Charity.Mvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Charity.Mvc.Services
{
    public interface IInstitutionService
    {
        List<Institution> GetAllInstitutions();
        void AddInstitution(Institution institution);
        Institution GetInstitution(int? id);
        void UpdateInstitution(Institution institution);
        void RemoveInstitution(int id);

        Task<bool> SaveChangesAsync();
    }
}
