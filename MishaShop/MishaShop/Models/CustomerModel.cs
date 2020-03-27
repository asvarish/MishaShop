using System.ComponentModel.DataAnnotations;

namespace MishaShop.Models
{
    public class CustomerModel
    {
        public static object Users { get; internal set; }
        [Required(ErrorMessage = "Поле должно быть установлено")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required(ErrorMessage = "Поле должно быть установлено")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required(ErrorMessage = "Поле должно быть установлено")]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Поле должно быть установлено")]
        [DataType(DataType.PhoneNumber)]
        public string MobilePhone { get; set; }
    }
}
