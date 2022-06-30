using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final_Project.Models
{
    public class Navbar
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Settings Settings { get; set; }
        public int  SettingsId { get; set; }
    }
}
