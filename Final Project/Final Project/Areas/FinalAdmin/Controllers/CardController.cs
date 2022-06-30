using Final_Project.DAL;
using Final_Project.Models;
using Final_Project.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final_Project.Areas.FinalAdmin.Controllers
{
    public class CardController : Controller
    {
        private readonly AppDbContext context;

        public CardController(AppDbContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            HomeVM home = new HomeVM
            {
                Cards = context.Cards.FirstOrDefault(),
Socialicons =context.Socialicons.ToList()
            };
            return View(home);
        }
        public IActionResult Create()
        {
            return View();
        }
        //public async Task<IActionResult> Create()
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return View();
        //    }
           
        //}
    }
}
