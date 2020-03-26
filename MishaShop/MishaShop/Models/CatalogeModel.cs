using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace MishaShop.Models
{
    public class CatalogeModel
    {
       public List<Good> Goods { get; set; }

        public List<IdentityUser> Users { get; set; }

        public string FilePath { get; set; }
    }
}
