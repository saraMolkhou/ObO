using clean.core.Entities;
using clean.core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clean.services
{
    public class orderServies
    {
        private readonly IOrderRepository _orderRepository;
        public orderServies(IOrderRepository oR)
        {
            _orderRepository = oR;
        }
        public List<order> GetAll()
        {
            return _orderRepository.GetList();
        }
        public order GetOrderById(int id)
        {
            return _orderRepository.GetById(id);
        }
        public void AddOrder(order ord)
        {
            _orderRepository.Add(ord);
        }
        public void UpdateOrder(order ord, int num)
        {
            _orderRepository.Update(ord, num);
        }
    }
}
