using clean.core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clean.core.Repositories
{
    public interface IProductRepository
    {
        List<product> GetList();
        product GetById(string barcode);
        void Add(product product);
        void Update(product prod, string barcode);
        void Remove(string barcode);
    }
}
