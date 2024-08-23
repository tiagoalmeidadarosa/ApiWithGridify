using ApiWithGridify.Models;
using ApiWithGridify.Repository;
using Gridify;

namespace ApiWithGridify.Services
{
    public interface IProductService
    {
        Paging<Product> GetFilteredProducts(GridifyQuery gridifyQuery);
    }

    public class ProductService(IProductRepository productRepository) : IProductService
    {
        private readonly IProductRepository _productRepository = productRepository;

        public Paging<Product> GetFilteredProducts(GridifyQuery gridifyQuery)
        {
            var products = _productRepository.GetProducts().Gridify(gridifyQuery);
            return products;
        }
    }
}
