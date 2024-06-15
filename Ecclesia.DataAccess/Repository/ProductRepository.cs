using Ecclesia.DataAccess.Data;
using Ecclesia.DataAccess.Repository.IRepository;
using Ecclesia.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecclesia.DataAccess.Repository
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private ApplicationDbContext _db;
        public ProductRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }


        public void Update(Product obj)
        {
            //_db.Products.Update(obj);
            var objfromDb = _db.Products.FirstOrDefault(u => u.Id == obj.Id);
            if (objfromDb != null)
            { 
                objfromDb.Title = objfromDb.Title;
                objfromDb.ISBN = objfromDb.ISBN;
                objfromDb.ListPrice = objfromDb.ListPrice;
                objfromDb.Description = objfromDb.Description;
                objfromDb.CategoryId = objfromDb.CategoryId;
                if(obj.ImageUrl != null)
                {
                    objfromDb.ImageUrl = obj.ImageUrl;
                }
            }

        }
    }
}
