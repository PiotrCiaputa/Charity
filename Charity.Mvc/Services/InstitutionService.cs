using Charity.Mvc.Data;
using Charity.Mvc.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Charity.Mvc.Services
{
    public class InstitutionService : IInstitutionService
    {
        private readonly AppDbContext _context;

        public InstitutionService(AppDbContext context)
        {
            _context = context;
        }

        public List<Institution> GetAllInstitutions()
        {
            return _context.Institutions.OrderBy(x => x.Id).ToList();
        }

        public int InstitutionsQuantity()
        {
            return _context.Institutions.ToList().Count;
        }

        public void AddInstitution(Institution institution)
        {
            _context.Institutions.Add(institution);
        }        

        public Institution GetInstitution(int? id)
        {
            return _context.Institutions.FirstOrDefault(x => x.Id == id);
        }

        public void UpdateInstitution(Institution institution)
        {
            _context.Institutions.Update(institution);
        }

        public void RemoveInstitution(int id)
        {
            _context.Institutions.Remove(GetInstitution(id));
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
