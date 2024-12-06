using ApiWithGridify.Models;
using ApiWithGridify.Repository;
using Gridify;

namespace ApiWithGridify.Services
{
    public class ProductService
    {
        private readonly ProductRepository _productRepository;

        public ProductService(ProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public Paging<Product> GetFilteredProducts(GridifyQuery gridifyQuery)
        {
            var products = _productRepository.GetProducts()
                //.ApplyFiltering(gridifyQuery)
                //.ApplyOrdering(gridifyQuery)
                //.ApplyPaging(gridifyQuery.Page, gridifyQuery.PageSize)
                .Gridify(gridifyQuery);

            return products;
        }
    }
}
