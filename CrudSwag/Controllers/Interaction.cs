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
    public class InteractionController : ControllerBase
    {
        private readonly CRUDContext _CRUDContext;
       

        public InteractionController(CRUDContext CRUDContext)
        {
            _CRUDContext = CRUDContext;
        }

        // GET: api/<Interaction>
        [HttpGet]
        public IEnumerable<Interaction> Get()
        {
            return _CRUDContext.Interaction;
        }

        // POST api/<Interaction>
        [HttpPost]
        public void Post([FromBody] Interaction interaction)
        {
            _CRUDContext.Interaction.Add(interaction);
            _CRUDContext.SaveChanges();
        }


        // DELETE api/<Interaction>/5
        [HttpDelete("{id}")]
        public void Delete(int task_id, int project_id)
        {
            var item = _CRUDContext.Interaction.FirstOrDefault(x => x.TaskId == task_id);
            var item1 = _CRUDContext.Interaction.FirstOrDefault(y => y.ProjectId == project_id);
            if (item != null && item1 != null)
            {
                _CRUDContext.Interaction.Remove(item);
                _CRUDContext.SaveChanges();
            }
        }
    }
}
