using Microsoft.AspNetCore.Mvc;
using School.Domain.Entities;
using School.Infrastructure.Interfaces;
using School.Infrastructure.Models;

namespace School.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartamentosController : ControllerBase
    {
        private readonly IDepartmentRepository _departmentRepository;

        public DepartamentosController(IDepartmentRepository departmentRepository)
        {
            _departmentRepository = departmentRepository;
        }

        // GET: api/Departamentos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DepartmentModel>>> GetDepartamentos()
        {
            var departments = await _departmentRepository.GetAll();
            var models = departments.Select(d => new DepartmentModel
            {
                Id = d.Id,
                Nombre = d.Name,
                Presupuesto = d.Budget
            }).ToList();
            return Ok(models);
        }

        // GET: api/Departamentos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DepartmentModel>> GetDepartamento(int id)
        {
            var department = await _departmentRepository.GetById(id);
            if (department == null)
            {
                return NotFound();
            }
            var model = new DepartmentModel
            {
                Id = department.Id,
                Nombre = department.Name,
                Presupuesto = department.Budget
            };
            return Ok(model);
        }

        // POST: api/Departamentos
        [HttpPost]
        public async Task<ActionResult<DepartmentModel>> PostDepartamento([FromBody] DepartmentModel model)
        {
            var newDepartment = new Department
            {
                Name = model.Nombre,
                Budget = model.Presupuesto,
                StartDate = DateTime.UtcNow
            };

            await _departmentRepository.Add(newDepartment);

            model.Id = newDepartment.Id;
            return CreatedAtAction(nameof(GetDepartamento), new { id = newDepartment.Id }, model);
        }

        // PUT: api/Departamentos/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDepartamento(int id, [FromBody] DepartmentModel model)
        {
            if (id != model.Id)
            {
                return BadRequest();
            }
            var departmentToUpdate = await _departmentRepository.GetById(id);
            if (departmentToUpdate == null)
            {
                return NotFound();
            }

            departmentToUpdate.Name = model.Nombre;
            departmentToUpdate.Budget = model.Presupuesto;

            await _departmentRepository.Update(departmentToUpdate);
            return NoContent();
        }

        // DELETE: api/Departamentos/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDepartamento(int id)
        {
            var department = await _departmentRepository.GetById(id);
            if (department == null)
            {
                return NotFound();
            }
            await _departmentRepository.Delete(id);
            return NoContent();
        }
    }
}