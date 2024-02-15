using clean.core.Entities;
using clean.core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clean.Data.Repository
{
    public class productRepository: IProductRepository
    {
        private readonly DataContext _context;
        public productRepository(DataContext context)
        {
            _context = context;
            _context.SaveChanges();
        }
        public List<product> GetList()
        {
            //_context.SaveChanges();
            return _context.Products.ToList();
        }
        public product GetById(string barcode)
        {
            foreach (product product in _context.Products)
            {
                if (product.Barcode == barcode)
                    //_context.SaveChanges();
                    return product;
            }
            //_context.SaveChanges();
            return null;
        }
        public void Add(product product)
        {
            product new_product = new product { Barcode = product.Barcode, Price = product.Price, ProdName = product.ProdName, Brand = product.Brand };
            _context.Products.Add(new_product);
            _context.SaveChanges();
        }
        public void Update(product prod, string barcode)
        {
            foreach (var product in _context.Products)
            {
                if (product.Barcode.Equals(barcode))
                {
                    product.Barcode = prod.Barcode;
                    product.Price = prod.Price;
                    product.ProdName = prod.ProdName;
                    product.Brand = prod.Brand;
                    _context.SaveChanges();
                }
            }
          
        }
        public void Remove(string barcode)
        {
            foreach (var prod in _context.Products)
            {
                if (prod.Barcode.Equals(barcode))
                {
                    _context.Products.Remove(prod);
                    _context.SaveChanges();
                }
            }
        }
    }
}

