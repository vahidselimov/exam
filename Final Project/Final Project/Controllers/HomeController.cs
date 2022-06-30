using Final_Project.DAL;
using Final_Project.Models;
using Final_Project.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final_Project.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext context;

        public HomeController(AppDbContext context)
        {
            this.context = context;
        }
        public async Task< IActionResult> Index()
        {

            HomeVM home = new HomeVM
            {
                Socialicons=await context.Socialicons.ToListAsync(),
Cards=await context.Cards.FirstOrDefaultAsync()
            };
            return View(home);


        }
       
    }
}
