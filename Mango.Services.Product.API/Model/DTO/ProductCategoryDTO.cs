using System.ComponentModel.DataAnnotations;

namespace Mango.Services.Product.API.Model.DTO
{
    public class ProductCategoryDTO
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }
    }
}
