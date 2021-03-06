﻿using Charity.Mvc.Models;
using Charity.Mvc.Models.Select;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Charity.Mvc.Services
{
    public interface IInstitutionService
    {
        List<Institution> GetAllInstitutions();
        List<InstitutionSelect> SelectInstitutions();
        void AddInstitution(Institution institution);
        Institution GetInstitution(int? id);
        void UpdateInstitution(Institution institution);
        void RemoveInstitution(int id);

        Task<bool> SaveChangesAsync();
    }
}
