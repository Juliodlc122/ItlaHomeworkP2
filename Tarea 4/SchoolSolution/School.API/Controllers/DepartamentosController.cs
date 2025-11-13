using Microsoft.AspNetCore.Mvc;
using School.Application.Contract;
using School.Application.Dtos.Department;

namespace School.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartamentosController : ControllerBase
    {

        private readonly IDepartamentService _departamentService;

        public DepartamentosController(IDepartamentService departamentService)
        {
            _departamentService = departamentService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<DepartmentDto>>> GetDepartamentos()
        {
            var result = await _departamentService.GetAll();
            return Ok(result.Data);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<DepartmentDto>> GetDepartamento(int id)
        {
            var result = await _departamentService.GetById(id);
            if (!result.Success)
            {
                return NotFound(new { message = result.Message });
            }
            return Ok(result.Data);
        }

        [HttpPost]
        public async Task<ActionResult<DepartmentDto>> PostDepartamento([FromBody] DepartmentCreateDto createDto)
        {
            var result = await _departamentService.Add(createDto);
            if (!result.Success)
            {

                return BadRequest(new { message = result.Message });
            }

            return CreatedAtAction(nameof(GetDepartamento), new { id = result.Data.Id }, result.Data);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutDepartamento(int id, [FromBody] DepartmentDto dto)
        {
            var result = await _departamentService.Update(dto, id);
            if (!result.Success)
            {
                return BadRequest(new { message = result.Message });
            }
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDepartamento(int id)
        {
            var result = await _departamentService.Delete(id);
            if (!result.Success)
            {
                return NotFound(new { message = result.Message });
            }
            return NoContent();
        }
    }
}