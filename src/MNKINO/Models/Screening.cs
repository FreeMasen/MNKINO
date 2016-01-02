using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MNKINO.Models
{
    public class Screening
    {
        public int Number { get; set; }
        public string Theme { get; set; }
        public Uri MysteryMeat { get; set; }
        public ICollection<Video> Videos { get; set; } 
    }
}
