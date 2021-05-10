using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace CoffeeShop
{
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
}
