using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Org.BouncyCastle.Utilities;

namespace MNKINO.ViewModels
{
    public class NextScreeningViewModel
    {
        public string Theme { get; set; }
        public DateTime Date { get; set; }
        public Int32 ScreeningNumber { get; set; }
        public Uri MysteryMeat { get; set; }
    }
}
