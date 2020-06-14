using Charity.Mvc.Models;
using Charity.Mvc.Models.Select;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace Charity.Mvc.ViewModels
{
    public class DonationViewModel 
    {       
        public List<InstitutionSelect> Institutions { get; set; }
        public List<Donation> Donations { get; set; }
        public int Quantity { get; set; }
        public int SupportedInstitutions { get; set; }

        public int CategoryID { get; set; }
        public List<SelectListItem> Categories { get; set; } = new List<SelectListItem>();
       
        public Donation Donation { get; set; }
    }
}
