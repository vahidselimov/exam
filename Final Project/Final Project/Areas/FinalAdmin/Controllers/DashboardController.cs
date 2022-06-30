using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final_Project.Areas.FinalAdmin.Controllers
{
    public class DashboardController : Controller
    {
       [Area("FinalAdmin)")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
