using CoffeeShop.Models;

namespace CoffeShop.Services
{
    public interface IProductService
    {
        IEnumerable<Product> GetAllProducts();

        Product? GetProductDetail(int id);


        void Create(Product product);


        void Delete(int id);


        void Edit(Product product);

        Product? Edit(int id);


    }
}