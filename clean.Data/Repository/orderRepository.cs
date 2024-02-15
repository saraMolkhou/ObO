using clean.core.Entities;
using clean.core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clean.Data.Repository
{
    public class orderRepository: IOrderRepository
    {
        private readonly DataContext _context;
        public orderRepository(DataContext context)
        {
            _context = context;
            _context.SaveChanges();
        }
        public List<order> GetList()
        {
            return _context.Orders.ToList();
        }
        public order GetById(int oNum)
        {
            foreach (order ord in _context.Orders)
            {
                if (ord.orderNum == oNum)
                    return ord;
            }
            return null;
        }
        public void Add(order ord)
        {
            order new_order = new order { orderNum = ord.orderNum, Status = ord.Status, orderSum = ord.orderSum, orderDate = ord.orderDate };
            _context.Orders.Add(new_order);
            _context.SaveChanges();
        }
        public void Update(order order, int oNum)
        {
            foreach (order ord in _context.Orders)
            {
                if (ord.orderNum == oNum)
                {
                    ord.Status = order.Status;
                    ord.orderNum = order.orderNum;
                    ord.orderSum = order.orderSum;
                    ord.orderDate = order.orderDate;
                    _context.SaveChanges();
                }

            }
        }
    }
}
