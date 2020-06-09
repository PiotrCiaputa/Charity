using Charity.Mvc.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Charity.Mvc.Services
{
    public interface IDonationService
    {
        List<Donation> GetAllDonations();
        int GetDonationsQuantity();
        int SupportedInstitutions();
        void AddDonation(Donation donation);
        Donation GetDonation(int? id);
        void UpdateDonation(Donation donation);
        void RemoveDonation(int id);

        Task<bool> SaveChangesAsync();
    }
}
