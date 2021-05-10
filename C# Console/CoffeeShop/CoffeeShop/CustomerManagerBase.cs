using System;

namespace CoffeeShop
{
    abstract class CustomerManagerBase : ICustomerManager
    {
        protected IRepository<Customer> _repository;

        public CustomerManagerBase(IRepository<Customer> repository)
        {
            _repository = repository;
        }

        public virtual void Register(Customer customer)
        {
            _repository.Add(customer);
            Console.WriteLine("Customer has been saved");
        }
    }
}
