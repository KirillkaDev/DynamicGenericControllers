using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericControllersExample.Services
{
    public class Storage<T> where T : class
    {
        private readonly Dictionary<Guid, T> _storage = new Dictionary<Guid, T>();

        public IEnumerable<T> GetAll() => _storage.Values;

        public T GetById(Guid id)
        {
            return _storage.FirstOrDefault(x => x.Key == id).Value;
        }

        public void AddOrUpdate(Guid id, T item)
        {
            if (_storage.ContainsKey(id))
            {
                _storage[id] = item;
            }
        }
    }
}
