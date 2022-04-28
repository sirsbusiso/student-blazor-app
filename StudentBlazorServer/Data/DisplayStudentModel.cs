using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudentBlazorServer.Data
{
    public class DisplayStudentModel
    {
        [Required]
        [StringLength(50, ErrorMessage = "Name is too long.")]
        [MinLength(3, ErrorMessage = "Name is too short.")]
        public string Name { get; set; }
        [Required]
        [StringLength(50, ErrorMessage = "Name is too long.")]
        [MinLength(3, ErrorMessage = "Name is too short.")]
        public string Surname { get; set; }
        [Required]
        public int Age { get; set; }
    }
}
