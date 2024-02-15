using clean.core.Entities;
using clean.core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clean.services
{
    public class productServies
    {
        private readonly IProductRepository _productRepository;
        public productServies(IProductRepository pR)
        {
           _productRepository = pR;
        }
        public List<product> GetAll()
        {
            return _productRepository.GetList();
        }
        public product GetProductById(string barcode)
        {
            return _productRepository.GetById(barcode);
        }
        public void AddProduct(product prod)
        {
            _productRepository.Add(prod);
        }
        public void UpdateProduct(product prod, string barcode)
        {
            _productRepository.Update(prod, barcode);
        }
        public void DeleteProduct(string barcode)
        {
            _productRepository.Remove(barcode);
        }
    }
}
