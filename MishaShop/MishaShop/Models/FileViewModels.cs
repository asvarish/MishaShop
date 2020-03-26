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
                Text ="Misha Sosi Hui",
                Value="Misha huilo"
            },
             new SelectListItem
            {
                Text ="Misha Sosi Hui",
                Value="Misha huilo"
            },
        new SelectListItem
            {
                Text ="Misha Sosi Hui",
                Value="Misha huilo"
            },
        new SelectListItem
            {
                Text ="Misha Sosi Hui",
                Value="Misha huilo"
            },
        new SelectListItem
            {
                Text ="Misha Sosi Hui",
                Value="Misha huilo"
            }};
        public string CustomerChoise { get; set; }
    }
}
