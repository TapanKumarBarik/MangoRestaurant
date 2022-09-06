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
        public async Task<IEnumerable<MangoProductDTO>> getAllMangoProduct()
        {
            var product= await applicationDbContext
                            .MangoProduct
                            .Include(x=>x.Category)
                            .ToListAsync();
            return mapper.Map<List<MangoProductDTO>>(product);
        }
    }
}
