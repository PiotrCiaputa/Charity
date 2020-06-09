using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Charity.Mvc.Models;
using Charity.Mvc.Services;
using Charity.Mvc.ViewModels;

namespace Charity.Mvc.Controllers
{
	public class HomeController : Controller
	{
		private readonly IInstitutionService _institutionService;
		private readonly IDonationService _donationService;

        public HomeController(IInstitutionService institutionService,
							  IDonationService donationService)
		{
			_institutionService = institutionService;
			_donationService = donationService;
        }
		public IActionResult Index()
		{
			var model = new IndexViewModel()
			{
				Institutions = _institutionService.GetAllInstitutions(),
				Quantity = _donationService.GetDonationsQuantity(),
				SupportedInstitutions = _donationService.SupportedInstitutions()		
			};

			return View(model);
		}

		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
