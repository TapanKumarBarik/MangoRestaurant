using Mango.Services.Product.API.Model.DTO;

namespace Mango.Services.Product.API.Repository
{
    public interface IProductRepository
    {
        Task<IEnumerable<MangoProductDTO>> GetAllMangoProductAsync();
        Task<MangoProductDTO> GetMangoProductByIdAsync(int id);
        Task<MangoProductDTO> GetMangoProductByNameAsync(string name);
        Task<MangoProductDTO> CreateMangoProductAsync(MangoProductDTO mangoProductDTO);
        Task<MangoProductDTO> UpdateMangoProductAsync(int Id,MangoProductDTO mangoProductDTO);
        Task<string> DeleteMangoProductByIDAsync(int Id);
    }
}
