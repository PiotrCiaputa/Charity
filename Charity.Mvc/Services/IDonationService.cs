using Charity.Mvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Charity.Mvc.Services
{
    public interface IDonationService
    {
        List<Donation> GetAllDonations();
        void AddDonation(Donation donation);
        Category GetDonation(int? id);
        void UpdateDonation(Donation donation);
        void RemoveDonation(int id);

        Task<bool> SaveChangesAsync();
    }
}
