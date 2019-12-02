using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TaskPlanner.Services.DtoModel;
using TaskPlanner.Services.Services.Task;

namespace TaskPlanner.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskController : ControllerBase
    {
        private readonly ITaskService _service;

        public TaskController(ITaskService service)
        {
            _service = service;
        }

        // GET: api/Task
        /// <summary>
        /// Поиск всех задач.
        /// </summary>
        /// <returns>Список всех задач.</returns>
        [HttpGet]
        public async Task<ActionResult<List<TaskModelDto>>> Get()
        {
            return await _service.FindAll();
        }

        // GET: api/Task/5
        /// <summary>
        /// Поиск задачи по id.
        /// </summary>
        /// <param name="id">Идентификатор задачи.</param>
        /// <returns>Данные задачи</returns>
        [HttpGet("{id}")]
        public async Task<ActionResult<TaskModelDto>> Get(Guid id)
        {
            return await _service.FindByID(id);
        }

        // POST: api/Task
        /// <summary>
        /// Добавление задачи.
        /// </summary>
        /// <param name="task">Данные задачи.</param>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] TaskModelDto task)
        {
            task.Id = Guid.Empty;
            task.Id = await _service.AddAsync(task);
            return CreatedAtAction("Get", new { id = task.Id }, task);
        }

        // PATCH: api/Task/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Patch(Guid id, [FromBody] TaskModelDto task)
        {
            if (id != task.Id)
            {
                return BadRequest();
            }

            if (await _service.Exists(id))
            {
                await _service.UpdateAsync(task);
            }
            else
            {
                return NotFound();
            }

            return NoContent();
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TaskModelDto>> Delete(Guid id)
        {
            var task = await _service.FindByID(id);

            if(task == null)
            {
                return BadRequest();
            }

            await _service.DeleteAsync(id);
            return task;
        }
    }
}
