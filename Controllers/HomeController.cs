using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MockAssessment7.DonutService;
using MockAssessment7.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MockAssessment7.Controllers
{
    public class HomeController : Controller
    {
        private readonly ISearchDonut donutClient;
        public HomeController(ISearchDonut donutClient)
        {
            this.donutClient = donutClient;
        }
        public IActionResult Index()
        {
            return View();
        }
        
        public async Task<IActionResult> Search(int Id)
        {
            var donut = await donutClient.SearchDonut(Id);
            var donutResult = new DonutSearchResult()
            {
                Name = donut.Name,
                Calories = donut.Calories,
                PhotoURL = donut.Photo,
                Extras = donut.Extras
            };

            return View(donutResult);
        }
    }
}
