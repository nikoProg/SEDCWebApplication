using SEDCWebApplication.DAL.DatabaseFactory.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDCWebApplication.DAL.DatabaseFactory.Interfaces
{
    public interface IProductDAL
    {
        void Save(Product item);

        Product GetById(int id);

        List<Product> GetAll(int skip, int take);

        void Delete(Product item);//mozda tip moze biti Product?
    }
}
