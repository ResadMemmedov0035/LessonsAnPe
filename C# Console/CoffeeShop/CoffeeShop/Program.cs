using System;

namespace CoffeeShop
{
    interface ICustomerCheckService
    {
        bool CustomerCheckCardNo(Customer customer);
    }

    class CustomerCheckService : ICustomerCheckService
    {
        public bool CustomerCheckCardNo(Customer customer)
        {
            return Convert.ToInt64(customer.CardNo) % 2 == 0;
        }
    }

    interface ICustomerManager
    {
        void Register(Customer customer);
    }

    abstract class CustomerManagerBase : ICustomerManager
    {
        public virtual void Register(Customer customer)
        {
            Console.WriteLine($"{customer.Name} has been saved to db!");
        }
    }

    class StarbucksCustomerManager : CustomerManagerBase
    {
        private ICustomerCheckService _checkService;

        public StarbucksCustomerManager(ICustomerCheckService checkService)
        {
            _checkService = checkService;
        }

        public override void Register(Customer customer)
        {
            if (_checkService.CustomerCheckCardNo(customer))
                base.Register(customer);
            else
                throw new Exception("Invalid Card Number!");
        }
    }

    class NeroCustomerManager : CustomerManagerBase
    {

    }

    class Program
    {
        static void Main(string[] args)
        {

            //CustomerManagerBase manager = new StarbucksCustomerManager(new CustomerCheckService());
            //manager.Register(new Customer { Name = "Resad" , CardNo = "12345"});
        }
    }
}
