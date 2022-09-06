using System.ComponentModel.DataAnnotations;

namespace Mango.Services.Product.API.Model
{
    public class MangoProduct
    {
        [Key]
        public int ProductID { get; set; }
        [Required]
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        [Range(1,10000)]
        public double Price { get; set; }
        public int Categoryid { get; set; }
        public string ImageURL { get; set; }

        public ProductCategory Category { get; set; }

    }
}
