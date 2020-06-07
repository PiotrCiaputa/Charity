using Charity.Mvc.Data;
using Charity.Mvc.Models;
using System.Collections.Generic;
using System.Linq;
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
            return _context.Donations.OrderBy(x => x.Quantity).ToList();
        }

        public int GetDonationsQuantity()
        {
            var quantity = _context.Donations.Select(x => x.Quantity).ToList().Sum();
            return (int)quantity;
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
