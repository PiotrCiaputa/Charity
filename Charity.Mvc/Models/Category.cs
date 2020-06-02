using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Charity.Mvc.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int DonationId { get; set; }
        public Donation Donation { get; set; }
    }
}
