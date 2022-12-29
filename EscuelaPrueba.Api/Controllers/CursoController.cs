using AutoMapper;
using EscuelaPrueba.Core.DTOs;
using EscuelaPrueba.Core.Interface;
using EscuelaPrueba.Infraestructure.Data;
using EscuelaPrueba.Infraestructure.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace EscuelaPrueba.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CursoController : Controller
    {
        private ICusosRepository _cusosRepository;

        private readonly IMapper _mapper;

        public CursoController(ICusosRepository cursosRepository, IMapper mapper)
        {
            _cusosRepository = cursosRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetEstudiante()
        {
            var cursos = await _cusosRepository.GetCursos();

            var cursosDto = _mapper.Map<IEnumerable<CursoDto>>(cursos);

            return (Ok(cursosDto));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetEstudianteId(int id)
        {

            var cursos = await _cusosRepository.GetCursosId(id);

            var cursosDto = _mapper.Map<CursoDto>(cursos);

            return Ok(cursosDto);
        }
        [HttpPost]
        public async Task<IActionResult> InsertCursos(Curso newCurso)
        {
            await _cusosRepository.PostCursos(newCurso);

            CursoDto newCursoDto = _mapper.Map<CursoDto>(newCurso);

            return Ok(newCursoDto);
        }
    }
}
