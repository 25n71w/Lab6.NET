using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Lab6.NET.Models
{
    public class Student : StudentBase
    {

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name ="Student ID")]
        public Guid ID { get; set; }
    }
}
