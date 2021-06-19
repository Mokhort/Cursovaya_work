using Kursovaya_work.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Kursovaya_work.DB;

namespace Kursovaya_work.Controllers
{
    public class HomeController : BaseController
    {
        private readonly ILogger<HomeController> logger;

       
        public HomeController(ILogger<HomeController> logger)
        {
            this.logger = logger;
        }

        //[HttpPost]
        //public async Task<IActionResult> Index(IndexModel model)
        //{

        //    if (!ModelState.IsValid)
        //        return View(model);
        //    Flight flight = context.Flight.Find(model.Time_Departure);
        //    if (flight != null)
        //    {
                
        //    }
        //    else
        //    {
        //        ModelState.AddModelError("", "We have not flight on this date");
        //        return (View(model));
        //    }
        //}
        public IActionResult Index()
        {
            return View(/*new IndexModel(context)*/);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
