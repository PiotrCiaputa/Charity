using Charity.Mvc.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace Charity.Mvc.ViewModels
{
    public class IndexViewModel 
    {
        public List<Institution> Institutions { get; set; }
        public List<Donation> Donations { get; set; }
        public int Quantity { get; set; }
        public int SupportedInstitutions { get; set; }

        public int CategoryID { get; set; }
        public List<Category> Categories { get; set; } 
        public Donation Donation { get; set; }
    }
}
