using Mango.Services.Product.API.Model.DTO;

namespace Mango.Services.Product.API.Repository
{
    public interface IProductRepository
    {
        Task<IEnumerable<MangoProductDTO>> getAllMangoProduct();
    }
}
