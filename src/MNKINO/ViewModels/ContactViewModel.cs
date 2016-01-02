using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MNKINO.ViewModels
{
    public class ContactViewModel
    {
        [Required]
        [StringLength(255,MinimumLength = 3)]
        public string From { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [StringLength(1024,MinimumLength = 10)]
        public string Message { get; set; }
    }
}
