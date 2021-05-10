namespace CoffeeShop
{
    class NeroCustomerManager : CustomerManagerBase
    {
        public NeroCustomerManager(IRepository<Customer> repository) 
               : base(repository)
        {

        }
    }
}
