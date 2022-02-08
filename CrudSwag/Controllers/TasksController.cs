using CrudSwag.Context;
using CrudSwag.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CrudSwag.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TasksController : ControllerBase
    {
        private readonly CRUDContext _CRUDContext;

        public TasksController(CRUDContext CRUDContext)
        {
            _CRUDContext = CRUDContext;
        }

        // GET: api/<TasksController1>
        [HttpGet]
        public IEnumerable<Tasks> Get()
        {
            return _CRUDContext.Tasks;
        }

        // GET api/<TasksController1>/5
        [HttpGet("{id}")]
        public Tasks Get(int id)
        {
            return _CRUDContext.Tasks.SingleOrDefault(x => x.TaskId == id);
        }

        // POST api/<TasksController1>
        [HttpPost]
        public void Post([FromBody] Tasks tasks)
        {
            _CRUDContext.Tasks.Add(tasks);
            _CRUDContext.SaveChanges();
        }

        // PUT api/<TasksController1>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Tasks tasks)
        {
            _CRUDContext.Tasks.Update(tasks);
            _CRUDContext.SaveChanges();
        }

        // DELETE api/<TasksController1>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var item = _CRUDContext.Tasks.FirstOrDefault(x => x.TaskId == id);
            if (item != null)
            {
                _CRUDContext.Tasks.Remove(item);
                _CRUDContext.SaveChanges();
            }
        }
    }
}
