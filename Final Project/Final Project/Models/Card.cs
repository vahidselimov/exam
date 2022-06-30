using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final_Project.Models
{
    public class Card
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public List<Socialicons>Socialicons  { get; set; }
    }
}
