using System;

namespace CoffeeShop
{
    class StarbucksCustomerManager : CustomerManagerBase
    {
        private ICustomerCheckService _checkService;

        public StarbucksCustomerManager(ICustomerCheckService checkService, IRepository<Customer> repository) 
               : base(repository)
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
}
