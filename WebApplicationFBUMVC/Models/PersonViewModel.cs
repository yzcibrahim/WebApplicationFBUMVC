using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationFBUMVC.Validations;

namespace WebApplicationFBUMVC.Models
{
    public class PersonViewModel
    {
        public int Id { get; set; }

        [Palindrom]
        [NotEqual]
        [Required(ErrorMessage ="Name zorunludur")]
        public string Name { get; set; }

        [NotEqName]
        [Required]
        [MinLength(2)]
        [NotEqual(kim ="kaAn")]
        public string Surname { get; set; }
    }
}
