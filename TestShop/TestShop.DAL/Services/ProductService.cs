using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestShop.DAL.Entities;

namespace TestShop.DAL.Services
{
    public class ProductService
    {
        ShopDataContext db = new ShopDataContext();

        public List<Product> GetProducts()
        {
            return db.Products.AsNoTracking().ToList();
        }
    }
}
