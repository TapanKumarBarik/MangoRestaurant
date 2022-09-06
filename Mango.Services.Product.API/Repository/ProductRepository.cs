using AutoMapper;
using Mango.Services.Product.API.Data;
using Mango.Services.Product.API.Model;
using Mango.Services.Product.API.Model.DTO;
using Microsoft.EntityFrameworkCore;

namespace Mango.Services.Product.API.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationDbContext applicationDbContext;
        private readonly IMapper mapper;
        public ProductRepository(
            ApplicationDbContext applicationDbContext,
            IMapper mapper
            )
        {
            this.applicationDbContext = applicationDbContext;
            this.mapper = mapper;
        }

        public async Task<MangoProductDTO> CreateMangoProductAsync(MangoProductDTO mangoProductDTO)
        {
            var mangoProduct = mapper.Map<MangoProduct>(mangoProductDTO);
            var res = await applicationDbContext.MangoProduct.AddAsync(mangoProduct);
            await applicationDbContext.SaveChangesAsync();
            return mapper.Map<MangoProductDTO>(mangoProduct);
        }

        public async Task<string> DeleteMangoProductByIDAsync(int Id)
        {
            var product = await applicationDbContext.MangoProduct.FirstOrDefaultAsync(x => x.ProductID == Id);

            if(product == null)
            {
                return "Product with ID "+ Id + " not found";
            }
            applicationDbContext.MangoProduct.Remove(product);
            await applicationDbContext.SaveChangesAsync();
            return "Product with ID " + Id + " deleted successfully";

        }

        public async Task<IEnumerable<MangoProductDTO>> GetAllMangoProductAsync()
        {
            var product= await applicationDbContext
                            .MangoProduct
                            .Include(x=>x.Category)
                            .ToListAsync();
            return mapper.Map<List<MangoProductDTO>>(product);
        }

        public async Task<MangoProductDTO> GetMangoProductByIdAsync(int id)
        {
            var product= await applicationDbContext.MangoProduct.FirstOrDefaultAsync(x=>x.ProductID == id);
            return mapper.Map<MangoProductDTO>(product);
        }

        public async Task<MangoProductDTO> GetMangoProductByNameAsync(string name)
        {
            var product = await applicationDbContext.MangoProduct.FirstOrDefaultAsync(x => x.ProductName.Contains( name));
            return mapper.Map<MangoProductDTO>(product);
        }

        public async Task<MangoProductDTO> UpdateMangoProductAsync(int Id, MangoProductDTO mangoProductDTO)
        {
            var product = await applicationDbContext.MangoProduct.FirstOrDefaultAsync(x => x.ProductID == Id);

            if (product == null)
            {
                return null;
            }
            product.ProductDescription = mangoProductDTO.ProductDescription;
            product.ProductName = mangoProductDTO.ProductName;
            product.Price = mangoProductDTO.Price;
            product.Categoryid = mangoProductDTO.Categoryid;
            product.ImageURL = mangoProductDTO.ImageURL;

            await applicationDbContext.SaveChangesAsync();
            return mapper.Map<MangoProductDTO>(product);
        }
    }
}
