using dotnetapp.Models;
using System.Linq;

namespace dotnetapp.Models
{
    public interface IProductService
    {
        public IQueryable<Product> GetProductList();
        public bool AddProduct(Product product);
        public bool DeleteProduct(int Id);
    }
    //Fill ur code
    public class ProductService : IProductService
    {
       private readonly ProductDBContext _dbContext;

        public ProductService(ProductDBContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IQueryable<Product> GetProductList()
        {
           return _dbContext.Product();
        }
        public bool AddProduct(Product product)
        {
            product.Add(Product);
            _dbContext.SaveChanges(product);
            return true;
        }

        public bool DeleteProduct(int Id)
        {
           var product1 = product.Find(Id);
           _dbContext.Remove(product1);
           return true;
        }
    }
}