using Final_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final_Project.ViewModels
{
    public class HomeVM
    {
        public Settings Settings { get; set; }
        public List<Navbar>Navbars { get; set; }
        public Card Cards { get; set; }
        public List<Socialicons> Socialicons { get; set; }
    }
}
