using CoffeeShop.Models;
using CoffeShop.Infrastructure.Repositories.Interfaces;

namespace CoffeShop.Services
{
    public class ProductService : IProductService
    {
        private IProductRepository productRepository;
        private IShoppingCartRepository shoppingCartRepository;
        public ProductService(IProductRepository productRepository, IShoppingCartRepository shoppingCartRepository)
        {
            this.productRepository = productRepository;
            this.shoppingCartRepository = shoppingCartRepository;   
        }
        public IEnumerable<Product> GetAllProducts()
        {
            return productRepository.GetAllProducts();
        }
        public Product? GetProductDetail(int id)
        {
           return productRepository.GetProductDetail(id);
            
        }
       

        public void Create(Product product)

        {
            productRepository.AddProduct(product);
        

        }
        public void Delete(int id)
        {
            shoppingCartRepository.RemoveAllProductFromCart(id);//delete all shoppingcartitems rows from cart

            productRepository.DeleteProduct(id);
            
        }

        public void Edit(Product product)

        {
            productRepository.EditProduct(product);

        }
        public Product? Edit(int id)
        {
            var product = productRepository.GetProductDetail(id);
            return product;
        }
    }


}