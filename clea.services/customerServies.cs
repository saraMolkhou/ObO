using clean.core.Entities;
using clean.core.Repositories;

namespace clean.services
{
    public class customerServies
    {
        private readonly ICustomerRepository _customerRepository;
        public customerServies(ICustomerRepository cR)
        {
            _customerRepository = cR;
        }
        public List<customer> GetAll()
        {
            return _customerRepository.GetList();
        }
        public customer GetCustomerById(int id)
        {
            return _customerRepository.GetById(id);
        }
        public void AddCustomer(customer customer)
        {
             _customerRepository.Add(customer);
        }
        public void UpdateCustomer(customer customer, int id)
        {
            _customerRepository.Update(customer, id);
        }
    }
}