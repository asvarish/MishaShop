using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MishaShop.Models
{
    public class ForBuy
    {
        public string City { get; set; }
        
        public string Street { get; set; }
        [Required]
        public string House { get; set; }
        
        [Required]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
    }
}
