namespace TestShop.DAL
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using TestShop.DAL.Entities;

    public class ShopDataContext : DbContext
    {        
        public ShopDataContext() : base("name=ShopDataContext")
        {
        }

        public DbSet<Product> Products { get; set; }
    }
}