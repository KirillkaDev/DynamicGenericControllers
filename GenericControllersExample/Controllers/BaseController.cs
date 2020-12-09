using System;
using System.Collections.Generic;
using GenericControllersExample.Models;
using GenericControllersExample.Services;
using Microsoft.AspNetCore.Mvc;

namespace GenericControllersExample.Controllers
{
    public class BaseController<T> : Controller where T : Entity
    {
        private readonly Storage<T> _storage;

        public BaseController(Storage<T> storage)
        {
            _storage = storage;
        }

        [HttpGet]
        public IEnumerable<T> Get()
        {
            return _storage.GetAll();
        }

        [HttpGet("{id}")]
        public T Get(Guid id)
        {
            return _storage.GetById(id);
        }

        [HttpPost]
        public void Post([FromBody]T value)
        {
            _storage.Create(value);
        }

        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            _storage.Delete(id);
        }
    }
}