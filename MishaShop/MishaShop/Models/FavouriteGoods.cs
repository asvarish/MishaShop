using Microsoft.AspNetCore.Identity;

namespace MishaShop.Models
{
    public class FavouriteGoods 
    {
        public int id { get; set; }
        public string GoodId { get; set; }
        public Good good { get; set; }
        public string UserId { get; set; }
        public IdentityUser User { get; set; }
    }
}