using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using DAL.EF6.Models;
using DAL.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace RESTFullServiceApp.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        private readonly IGenericRepository<Value> _repository;

        public ValuesController(IGenericRepository<Value> repository)
        {
            _repository = repository;
        }

        // GET: api/values
        [HttpGet]
        public IEnumerable<Value> Get()
        {
            return _repository.Get().ToList();
        }

        // GET: api/values/{id}
        [HttpGet("{id}")]
        public Value Get(int id)
        {
            return _repository.FindById(id);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] Value value)
        {
            _repository.Create(value);
        }

        // PUT api/values
        [HttpPut]
        public void Put([FromBody] Value value)
        {
            _repository.Update(value);
        }

        // DELETE api/values
        [HttpDelete("{id}")]
        public HttpResponseMessage Delete(int id)
        {
            var item = _repository.FindById(id);
            if (item == null)
                return new HttpResponseMessage(HttpStatusCode.NotFound);
            _repository.Remove(item);
            return new HttpResponseMessage(HttpStatusCode.OK);
        }
    }
}