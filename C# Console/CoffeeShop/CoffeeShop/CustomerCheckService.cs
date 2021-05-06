using System;

namespace CoffeeShop
{
    class CustomerCheckService : ICustomerCheckService
    {
        public bool CustomerCheckCardNo(Customer customer)
        {
            return Convert.ToInt64(customer.CardNo) % 2 == 0;
        }
    }
}
