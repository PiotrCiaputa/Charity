using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Charity.Mvc.Models;
using Charity.Mvc.Services;
using Charity.Mvc.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Charity.Mvc.Controllers
{
    public class DonationController : Controller
    {
        private readonly ICategoryService _categoryService;
        private readonly IInstitutionService _institutionService;
        private readonly IDonationService _donationService;
        public DonationController(ICategoryService categoryService,
                                  IInstitutionService institutionService,
                                  IDonationService donationService)
        {
            _categoryService = categoryService;
            _institutionService = institutionService;
            _donationService = donationService;
        }
        public IActionResult Donate()
        {            
            var model = new IndexViewModel()
            {      
                Categories = _categoryService.GetAllCategories(),
                Institutions = _institutionService.GetAllInstitutions(),
                Quantity = _donationService.GetDonationsQuantity(),
                SupportedInstitutions = _donationService.SupportedInstitutions(),
                Donation = _donationService.GetDonation(0),
                Donations = _donationService.GetAllDonations()
            };            

            return View(model);
        } 
                     
        [HttpPost]
        public IActionResult Donate(IndexViewModel model)
        {
            var donation = new Donation
            {
                
            };

            if (ModelState.IsValid)
            {
                _donationService.AddDonation(donation);
               _donationService.SaveChangesAsync();

                return RedirectToAction("Index", "Home");
            }

            return RedirectToAction("Index", "Home");
        }
    }
}
