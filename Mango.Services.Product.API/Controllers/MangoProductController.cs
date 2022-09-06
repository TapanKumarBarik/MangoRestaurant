using AutoMapper;
using Mango.Services.Product.API.Model;
using Mango.Services.Product.API.Model.DTO;
using Mango.Services.Product.API.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Mango.Services.Product.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MangoProductController : ControllerBase
    {
        private readonly IProductRepository productRepository;
        public MangoProductController(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }
        [HttpGet]
        [Route("/getAll")]
        public async Task<IActionResult> GetAllMangoProductsAsync()
        {
            var mangoResult = await productRepository.getAllMangoProduct();
            return Ok(mangoResult);
        }
    }
}
