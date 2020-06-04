using Charity.Mvc.Models;
using System.Collections.Generic;

namespace Charity.Mvc.ViewModels
{
    public class InstitutionViewModel
    {
        public IEnumerable<Institution> Institutions { get; set; }
    }
}
