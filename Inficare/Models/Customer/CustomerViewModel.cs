using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Inficare.Models
{
    public class CustomerViewModel
    {
        public string Name { get; set; }
        [Required()]
        public string Email { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
    }
}
