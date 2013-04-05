using System.Collections.Generic;
using System.Linq;

namespace PartialViewAspNet.Models
{
    public interface IProductRepositary
    {
        List<Product> GetAll();    
    }

    public class ProductRepositary : IProductRepositary
    {
        private MobiBookEntities _entities;

        public ProductRepositary()
        {
            _entities = new MobiBookEntities();
        }

        public List<Product> GetAll()
        {
            List<Product> products = _entities.Products.Take(50).ToList(); // Get top 50 records.
            return products;
        }
    }
}