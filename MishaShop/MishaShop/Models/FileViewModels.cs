using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MishaShop.Models
{
    public class FileViewModel
    {
        [Required(ErrorMessage = "Поле должно быть установлено")]
        public string Price { get; set; }
        [Required(ErrorMessage = "Поле должно быть установлено")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Поле должно быть установлено")]
        public IFormFile FileData { get; set; }
        public List<SelectListItem> Sizes { get; set; } = new List<SelectListItem> {
            new SelectListItem
            {
                Text ="Нет",
                Value="Нет"
            },
             new SelectListItem
            {
                Text ="S",
                Value="S"
            },
        new SelectListItem
            {
                Text ="M",
                Value="M"
            },
        new SelectListItem
            {
                Text ="L",
                Value="L"
            },
        new SelectListItem
            {
                Text ="XL",
                Value="XL"
            }};
        [Required(ErrorMessage = "Поле должно быть установлено")]
        [AllowNull]
        public string CustomerChoise { get; set; }
    }
}
