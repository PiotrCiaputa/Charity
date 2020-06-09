using Charity.Mvc.Data;
using Charity.Mvc.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace Charity.Mvc.Services
{
    public class DonationService : IDonationService
    {
        private readonly AppDbContext _context;

        public DonationService(AppDbContext context)
        {
            _context = context;
        }

        public List<Donation> GetAllDonations()
        {
            return _context.Donations.ToList();
        }

        public int GetDonationsQuantity()
        {
            var quantity = _context.Donations.Select(x => x.Quantity).ToList().Sum();
            return (int)quantity;
        }
        public int SupportedInstitutions()
        {
            var institutions = _context.Donations.Select(x => x.InstitutionId).ToList().Count;
            return institutions;            
        }

        public void AddDonation(Donation donation)
        {
            _context.Donations.Add(donation);
        }        

        public Donation GetDonation(int? id)
        {
            return _context.Donations.FirstOrDefault(x => x.Id == id);
        }

        public void UpdateDonation(Donation donation)
        {
            _context.Donations.Update(donation);
        }

        public void RemoveDonation(int id)
        {
            _context.Donations.Remove(GetDonation(id));
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
