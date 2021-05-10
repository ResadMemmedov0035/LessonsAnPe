using System;
using System.Text.RegularExpressions;

namespace CoffeeShop
{
    class CustomerCheckService : ICustomerCheckService
    {
        Regex regex = new Regex(@"(^AZE\d{8}$)|(^AA\d{7}$)");

        public bool CustomerCheckCardNo(Customer customer)
        {
            return regex.IsMatch(customer.CardNo);
        }
    }
}
