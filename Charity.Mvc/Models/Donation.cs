using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Charity.Mvc.Models
{
    public class Donation
    {
        public int Id { get; set; }
        public decimal Quantity { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }
        public DateTime PickUpDate { get; set; } = DateTime.UtcNow;
        public DateTime PickUpTime { get; set; } = DateTime.UtcNow;
        public DateTime PickUpComment { get; set; } = DateTime.UtcNow;

        public List<Category> Categories { get; set; }

        public int InstitutionId { get; set; }
        public Institution Institution { get; set; }
    }
}
