using DZ.Models;

namespace DZ.Service
{
    public interface IServiceProducts
    {
        public IEnumerable<Product> GetProducts();
        public Product GetProductById(int id);
        public void UpdateProduct(Product product);
        public void DeleteProduct(int id);
        public Product CreateProduct(Product product);

    }
    public class ServiceProducts : IServiceProducts
    {
        public readonly List<Product> products = new List<Product>
            {
                new Product { Id = 1, Name = "Product 1", Description = "Description for product 1" },
                new Product { Id = 2, Name = "Product 2", Description = "Description for product 2" },
                new Product { Id = 3, Name = "Product 3", Description = "Description for product 3" },
                new Product { Id = 4, Name = "Product 4", Description = "Description for product 4" },
                new Product { Id = 5, Name = "Product 5", Description = "Description for product 5" },
                new Product { Id = 6, Name = "Product 6", Description = "Description for product 6" },
                new Product { Id = 7, Name = "Product 7", Description = "Description for product 7" },
                new Product { Id = 8, Name = "Product 8", Description = "Description for product 8" },
                new Product { Id = 9, Name = "Product 9", Description = "Description for product 9" },
                new Product { Id = 10, Name = "Product 10", Description = "Description for product 10" }
            };

        public Product CreateProduct(Product product)
        {
            products.Add(product);
            return product;
        }

        public void DeleteProduct(int id)
        {
            products.Remove(products.Find(p => p.Id == id));
        }

        public Product GetProductById(int id)
        {
            return products.Find(p => p.Id == id);
        }

        public IEnumerable<Product> GetProducts()
        {
            return products.ToList();
        }

        public void UpdateProduct(Product product)
        {
            Product  product1 =  products.Find(p => p.Id == product.Id);
            product1.Id = products.Count() + 1;
            product1.Name = product.Name;
            product1.Description = product.Description;
        }
    }
}
