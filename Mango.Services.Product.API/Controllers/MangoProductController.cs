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
            var result = new ResponseDTO();
            try
            {
                var mangoResult = await productRepository.GetAllMangoProductAsync();
                result.Result = mangoResult;
            }
            catch (Exception ex)
            {
                result.IsSuccess = false;
                result.ErrorMessage = new List<string>() { ex.ToString() };
            }
            return Ok(result);    
        }

        [HttpGet]
        [Route("/{id:int}")]
        public async Task<IActionResult> GetMangoProductByIDAsync(int id)
        {
            var result = new ResponseDTO();
            try
            {
                var mangoProduct = await productRepository.GetMangoProductByIdAsync(id);
                result.Result = mangoProduct;
            }
            catch (Exception ex)
            {
                result.IsSuccess = false;
                result.ErrorMessage = new List<string>() { ex.ToString() };
            }
            return Ok(result);
           
        }
        [HttpGet]
        [Route("/{name}")]
        public async Task<IActionResult> GetMangoProductByProductNameAsync(string name)
        {
            var result = new ResponseDTO();
            try
            {
                var mangoProduct = await productRepository.GetMangoProductByNameAsync(name);
                result.Result = mangoProduct;
            }
            catch (Exception ex)
            {
                result.IsSuccess = false;
                result.ErrorMessage = new List<string>() { ex.ToString() };
            }
            return Ok(result);
        }

        [HttpDelete]
        [Route("/{id:int}")]
        public async Task<IActionResult> DeleteMangoProductByProductIDAsync(int id)
        {
            var result = new ResponseDTO();
            try
            {
                var mangoProduct = await productRepository.DeleteMangoProductByIDAsync(id);
                result.Result = mangoProduct;
            }
            catch (Exception ex)
            {
                result.IsSuccess = false;
                result.ErrorMessage = new List<string>() { ex.ToString() };
            }
            return Ok(result);
        }

        [HttpPost]
        [Route("/createProduct")]
        public async Task<IActionResult> CreateMangoProductByProductAsync(MangoProductDTO mangoProductDTO)
        {
            var result = new ResponseDTO();
            try
            {
                var mangoProduct = await productRepository.CreateMangoProductAsync(mangoProductDTO);
                result.Result = mangoProduct;
            }
            catch (Exception ex)
            {
                result.IsSuccess = false;
                result.ErrorMessage = new List<string>() { ex.ToString() };
            }
            return Ok(result);
        }

        [HttpPut]
        [Route("/updateProduct/{id:int}")]
        public async Task<IActionResult> UpdateMangoProductByProductAsync(int id,MangoProductDTO mangoProductDTO)
        {
            var result = new ResponseDTO();
            try
            {
                var mangoProduct = await productRepository.UpdateMangoProductAsync(id,mangoProductDTO);
                result.Result = mangoProduct;
            }
            catch (Exception ex)
            {
                result.IsSuccess = false;
                result.ErrorMessage = new List<string>() { ex.ToString() };
            }
            return Ok(result);
        }
    }
}
