using CoffeeShop.Models;

namespace CoffeShop.Infrastructure.Repositories.Interfaces

{
    public interface IProductRepository
    {

        IEnumerable<Product> GetAllProducts();
        IEnumerable<Product> GetTrendingProducts();
        Product? GetProductDetail(int id);
        void AddProduct(Product product);
        void EditProduct(Product product);
        void DeleteProduct(int id);
    }
}
