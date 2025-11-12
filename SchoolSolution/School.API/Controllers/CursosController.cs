using Microsoft.AspNetCore.Mvc;
using School.Domain.Entities;
using School.Infrastructure.Interfaces;
using School.Infrastructure.Models;

namespace School.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CursosController : ControllerBase
    {
        private readonly ICourseRepository _courseRepository;

        public CursosController(ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }

        // GET: api/Cursos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CursoModel>>> GetCursos()
        {
            var courses = await _courseRepository.GetAll();
            var cursoModels = courses.Select(course => new CursoModel
            {
                Id = course.Id,
                NombreCurso = course.Title,
                Creditos = course.Credits,
                DepartamentoId = course.DepartmentID
            }).ToList();

            return Ok(cursoModels);
        }

        // GET: api/Cursos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CursoModel>> GetCurso(int id)
        {
            var course = await _courseRepository.GetById(id);
            if (course == null)
            {
                return NotFound();
            }
            var cursoModel = new CursoModel
            {
                Id = course.Id,
                NombreCurso = course.Title,
                Creditos = course.Credits,
                DepartamentoId = course.DepartmentID
            };
            return Ok(cursoModel);
        }

        // POST: api/Cursos
        [HttpPost]
        public async Task<ActionResult<CursoModel>> PostCurso([FromBody] CursoModel cursoModel)
        {
            var newCourse = new Course
            {
                Title = cursoModel.NombreCurso,
                Credits = cursoModel.Creditos,
                DepartmentID = cursoModel.DepartamentoId
            };

            await _courseRepository.Add(newCourse);

            cursoModel.Id = newCourse.Id;
            return CreatedAtAction(nameof(GetCurso), new { id = newCourse.Id }, cursoModel);
        }

        // PUT: api/Cursos/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCurso(int id, [FromBody] CursoModel cursoModel)
        {
            if (id != cursoModel.Id)
            {
                return BadRequest();
            }
            var courseToUpdate = await _courseRepository.GetById(id);
            if (courseToUpdate == null)
            {
                return NotFound();
            }

            courseToUpdate.Title = cursoModel.NombreCurso;
            courseToUpdate.Credits = cursoModel.Creditos;
            courseToUpdate.DepartmentID = cursoModel.DepartamentoId;

            await _courseRepository.Update(courseToUpdate);
            return NoContent();
        }

        // DELETE: api/Cursos/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCurso(int id)
        {
            var course = await _courseRepository.GetById(id);
            if (course == null)
            {
                return NotFound();
            }
            await _courseRepository.Delete(id);
            return NoContent();
        }
    }
}