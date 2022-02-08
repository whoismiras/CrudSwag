using CrudSwag.Context;
using CrudSwag.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CrudSwag.Migrations.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectController : ControllerBase
    {
        private readonly CRUDContext _CRUDContext;

        public ProjectController(CRUDContext CRUDContext)
        { 
            _CRUDContext = CRUDContext;
        }


        // GET: api/<ProjectController>
        [HttpGet]
        public IEnumerable<Project> Get()
        {
            return _CRUDContext.Project;
        }

        // GET api/<ProjectController>/5
        [HttpGet("{id}")]
        public Project Get(int id)
        {
            return _CRUDContext.Project.SingleOrDefault(x => x.ProjectId == id);
        }

        // POST api/<ProjectController>
        [HttpPost]

        public void Post([FromBody] Project project)
        {   
            _CRUDContext.Project.Add(project);
            _CRUDContext.SaveChanges();
            
        }

        // PUT api/<ProjectController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Project project)
        {
            _CRUDContext.Project.Update(project);
            _CRUDContext.SaveChanges();
        }

        // DELETE api/<ProjectController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var item = _CRUDContext.Project.FirstOrDefault(x=>x.ProjectId == id);
            if(item != null)
            {
                _CRUDContext.Project.Remove(item);
                _CRUDContext.SaveChanges();
            }
        }
    }
}
