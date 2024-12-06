using ApiWithGridify.Models;

namespace ApiWithGridify.Repository
{
    public class ProductRepository
    {
        private readonly List<Product> _products;

        public ProductRepository()
        {
            // Sample data
            _products =
            [
                new Product { Id = 1, Name = "Product A", Price = 10.99m, Category = "Electronics" },
                new Product { Id = 2, Name = "Product B", Price = 24.50m, Category = "Home & Kitchen" },
                new Product { Id = 3, Name = "Product C", Price = 5.99m, Category = "Books" },
                new Product { Id = 4, Name = "Product D", Price = 49.99m, Category = "Sports & Outdoors" },
                new Product { Id = 5, Name = "Product E", Price = 15.75m, Category = "Beauty & Personal Care" },
                new Product { Id = 6, Name = "Product F", Price = 199.99m, Category = "Electronics" },
                new Product { Id = 7, Name = "Product G", Price = 34.95m, Category = "Toys & Games" },
                new Product { Id = 8, Name = "Product H", Price = 89.50m, Category = "Fashion" },
                new Product { Id = 9, Name = "Product I", Price = 12.25m, Category = "Office Supplies" },
                new Product { Id = 10, Name = "Product J", Price = 45.00m, Category = "Garden & Outdoor" }
            ];
        }

        public IQueryable<Product> GetProducts()
        {
            return _products.AsQueryable();
        }
    }
}
