using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final_Project.Models
{
    public class Settings
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string IconUrl { get; set; }
        public string Title { get; set; }
        public string p1 { get; set; }
        public string p2 { get; set; }
       public string FooterName { get; set; }
        public string FooterTitle { get; set; }
        public string LocIconUrl { get; set; }
        public string GmailIconUrl { get; set; }
        public string PhoneIconUrl { get; set; }
        public string LocText { get; set; }
        public string GmailText { get; set; }
        public string Phone { get; set; }

        public string Copyrigth { get; set; }

        public List<Navbar> Navbars  { get; set; }
    }
}
