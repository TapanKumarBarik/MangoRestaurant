using System.ComponentModel.DataAnnotations;

namespace Mango.Services.Product.API.Model.DTO
{
    public class MangoProductDTO
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public double Price { get; set; }
        public int Categoryid { get; set; }
        public string ImageURL { get; set; }
        public ProductCategory? Category { get; set; }
    }
}
