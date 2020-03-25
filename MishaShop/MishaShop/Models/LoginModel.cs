using System.ComponentModel.DataAnnotations;

namespace MishaShop.Models
{
    public class LoginModel
    {
        [DataType(DataType.EmailAddress)]
        public string EmailAddress { get; set; }
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
