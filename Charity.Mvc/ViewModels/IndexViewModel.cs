﻿using Charity.Mvc.Models;
using System.Collections.Generic;

namespace Charity.Mvc.ViewModels
{
    public class IndexViewModel
    {
        public IEnumerable<Institution> Institutions { get; set; }
        public int Quantity { get; set; }
        public int InstitutionsQuantity { get; set; }
    }
}