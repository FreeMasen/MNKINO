using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using MNKINO.Models;

namespace MNKINO.ViewModels
{
    public class SubmitViewModel
    {
        [Required]
        [StringLength(50, MinimumLength = 5)]
        public string AuthorName { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 3)]
        public string VideoTitle { get; set; }

        [Required]
        [EmailAddress]
        public string EmailAddress { get; set; }

        [Required]
        [Range(1,999)]
        public int ScreeningNumber { get; set; }

        [Required]
        [FileType]
        public string FilePath { get; set; }
    }
}
