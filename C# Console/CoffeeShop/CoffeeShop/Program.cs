using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace CoffeeShop
{
    interface ICustomerManager
    {
        void Register(Customer customer);
    }

    interface IRepository<T> where T : class
    {
        void Add(T item);
        void Remove(T item);
        IEnumerable<T> GetAll();
    }

    class JsonRepository<T> : IRepository<T> where T : class
    {
        private string path;
        private List<T> items;
        
        public JsonRepository(string path)
        {
            this.path = path;

            if (!File.Exists(path))
            {
                items = new List<T>();
            }
            else items = ReadFromFile();
        }

        public void Add(T item)
        {
            items.Add(item);
            WriteToFile();
        }

        public void Remove(T item)
        {
            items.Remove(item);
            WriteToFile();
        }

        public IEnumerable<T> GetAll() => items;


        private List<T> ReadFromFile()
        {
            var data = File.ReadAllText(path);
            return JsonSerializer.Deserialize<List<T>>(data);
        }

        private void WriteToFile()
        {
            var data = JsonSerializer.Serialize(items);
            File.WriteAllText(path, data);
        }
    }


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

    class NeroCustomerManager : CustomerManagerBase
    {
        public NeroCustomerManager(IRepository<Customer> repository) 
               : base(repository)
        {

        }
    }

    class Program
    {
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
                CardNo = "12348"
            });
        }
    }
}
