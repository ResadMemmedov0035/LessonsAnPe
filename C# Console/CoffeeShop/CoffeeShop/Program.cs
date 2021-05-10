using System;

namespace CoffeeShop
{
    class Program
    {
        static (string, int) TupleFoo()
        {
            return ("Resad", 17);
        }

        static void Main(string[] args)
        {
            CustomerManagerBase manager = new StarbucksCustomerManager(new CustomerCheckService(),
                                                                       new JsonRepository<Customer>("StarbucksCustomers.json"));
            manager.Register(new Customer
            {
                Id = 2,
                Name = "Rasim",
                Surname = "Aliyev",
                BirthDate = new DateTime(2000, 12, 14),
                CardNo = "AZE12345678"
            });
        }
    }
}
