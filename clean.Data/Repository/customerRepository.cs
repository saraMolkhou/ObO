using clean.core.Entities;
using clean.core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clean.Data.Repository
{
    public class customerRepository : ICustomerRepository
    {
        private readonly DataContext _context;
        public customerRepository(DataContext context)
        {
            _context = context;
            _context.SaveChanges();
        }
        public List<customer> GetList()
        {
            return _context.Customers.ToList();
        }
        public customer GetById(int id)
        {
            foreach (customer customer in _context.Customers)
            {
                if (customer.Id == id)
                    return customer;
            }
            return null;
        }
        public void Add(customer customer)
        {
            customer new_customer = new customer { Id = customer.Id, Name = customer.Name, Age = customer.Age, City = customer.City, HMO = customer.HMO };
            _context.Customers.Add(new_customer);
            _context.SaveChanges();
        }
        public void Update(customer customer, int id)
        {
            customer update_customer = new customer { Id = customer.Id, Name = customer.Name, Age = customer.Age, City = customer.City, HMO = customer.HMO };
            foreach (customer cust in _context.Customers)
            {
                if (cust.Id == id)
                {
                    cust.Id = update_customer.Id;
                    cust.Name = update_customer.Name;
                    cust.Age = update_customer.Age;
                    cust.City = update_customer.City;
                    cust.HMO = update_customer.HMO;
                    _context.SaveChanges();
                }

            }
        }

    }
}
