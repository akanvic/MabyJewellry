using MabyJewelrry.DataAccess.Data;
using MabyJewelrry.DataAccess.Repository.IRepository;
using MabyJewelrry.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MabyJewelrry.DataAccess.Repository
{

    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private readonly ApplicationDbContext _db;
        public ProductRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
        public void Update(Product product)
        {
            var objFromDb = _db.Products.FirstOrDefault(c => c.Id == product.Id);

            if(objFromDb != null)
            {
                if (product.ImageUrl != null)
                {
                    objFromDb.ImageUrl = product.ImageUrl;
                }
                objFromDb.Name = product.Name;
                objFromDb.Price = product.Price;
                objFromDb.Description = product.Description;
                objFromDb.CategoryId = product.CategoryId;
            }
        }
    }
}
