using System.ComponentModel.DataAnnotations;

namespace Mango.Services.Product.API.Model
{
    public class ProductCategory
    {
        [Key]
        public int CategoryID { get; set; }
        [Required]
        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }
    }
}
