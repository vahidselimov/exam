using Final_Project.DAL;
using Final_Project.Models;
using Final_Project.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final_Project.ViewComponents
{
    
    public class HeaderViewComponent:ViewComponent
    {
        private readonly AppDbContext context;

        public HeaderViewComponent(AppDbContext context)
        {
            this.context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            
            HomeVM home = new HomeVM
            {

                Settings= await context.Settings.FirstOrDefaultAsync(),
                 Navbars=await context.Navbars.ToListAsync()
            };
            return View(home);
        }
    }
}
