using System.ComponentModel.DataAnnotations;

namespace MishaShop.Models
{
    public class Good
    {  
        public string CustomerId { get; set; }
        [Key]
        public string FileId { get; set; }
        [Required]
        public string Price { get; set; }
        [MaxLength(600)]
        [Required]
        public string Description { get; set; }
        public string FileName { get; set; }
        public byte[] File { get; set; }
        public string Size { get; set; }
    }
}
