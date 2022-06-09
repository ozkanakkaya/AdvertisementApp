using Microsoft.AspNetCore.Mvc;
using Ozkky.AdvertisementApp.Business.Interfaces;
using Ozkky.AdvertisementApp.UI.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ozkky.AdvertisementApp.UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProvidedServiceService _providedServiceService;

        public HomeController(IProvidedServiceService providedServiceService)
        {
            _providedServiceService = providedServiceService;
        }

        public async Task<IActionResult> Index()
        {
            var response = await _providedServiceService.GetAllAsync();
            return this.ResponseView(response);
        }
    }
}
