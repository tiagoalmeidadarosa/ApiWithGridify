using ApiWithGridify.Services;
using Gridify;
using Microsoft.AspNetCore.Mvc;

namespace ApiWithGridify.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly ProductService _productService;

        public ProductsController(ProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        [ProducesResponseType(typeof(Paging<Models.Product>), StatusCodes.Status200OK)]
        public IActionResult GetProducts([FromQuery] GridifyQuery request)
        {
            var products = _productService.GetFilteredProducts(request);
            return Ok(products);
        }
    }
}
