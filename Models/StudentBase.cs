using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lab6.NET.Models
{
    public class StudentBase
    {
        [StringLength(50, MinimumLength = 1)]
        [Required]
        public String FirstName { get; set; }

        [StringLength(50, MinimumLength = 1)]
        [Required]
        public String LastName { get; set; }

        [StringLength(50, MinimumLength = 1)]
        [Required]
        public String Program { get; set; }
    }
}
