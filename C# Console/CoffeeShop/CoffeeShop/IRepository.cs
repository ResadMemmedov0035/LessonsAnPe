using System.Collections.Generic;

namespace CoffeeShop
{
    interface IRepository<T> where T : class
    {
        void Add(T item);
        void Remove(T item);
        IEnumerable<T> GetAll();
    }
}
