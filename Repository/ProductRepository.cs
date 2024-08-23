using ApiWithGridify.Models;

namespace ApiWithGridify.Repository
{
    public interface IProductRepository
    {
        IQueryable<Product> GetProducts();
    }

    public class ProductRepository : IProductRepository
    {
        private readonly List<Product> _products;

        public ProductRepository()
        {
            // Sample data
            _products =
            [
                new Product { Id = 1, Name = "Product A", Price = 10.99m, Category = "Category1" },
                new Product { Id = 2, Name = "Product B", Price = 20.99m, Category = "Category2" },
                new Product { Id = 3, Name = "Product C", Price = 30.99m, Category = "Category3" },
                new Product { Id = 4, Name = "Product D", Price = 40.99m, Category = "Category4" },
                new Product { Id = 5, Name = "Product E", Price = 50.99m, Category = "Category5" },
            ];
        }

        public IQueryable<Product> GetProducts()
        {
            return _products.AsQueryable();
        }
    }
}
