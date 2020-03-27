using System.ComponentModel.DataAnnotations;

namespace MishaShop.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Поле должно быть установлено")]
        [DataType(DataType.EmailAddress)]
        public string EmailAddress { get; set; }
        [Required(ErrorMessage = "Поле должно быть установлено")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
