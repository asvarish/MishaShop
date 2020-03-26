using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MishaShop.Models
{
    public class FileViewModel
    {
        [Required]
        public string Price { get; set; }
        [Required]
        public string Description { get; set; }
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
        public string CustomerChoise { get; set; }
    }
}
