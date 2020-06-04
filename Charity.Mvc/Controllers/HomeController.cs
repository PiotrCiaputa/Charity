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

        public HomeController(IInstitutionService institutionService)
		{
			_institutionService = institutionService;
        }
		public IActionResult Index()
		{
			var model = new InstitutionViewModel()
			{
				Institutions = _institutionService.GetAllInstitutions()
			};

			return View(model);
		}

		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
