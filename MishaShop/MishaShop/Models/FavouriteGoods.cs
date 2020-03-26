using Microsoft.AspNetCore.Identity;

namespace MishaShop.Models
{
    public class FavouriteGoods : Good 
    {
        public string UserId { get; set; }
        public IdentityUser User { get; set; }
    }
}