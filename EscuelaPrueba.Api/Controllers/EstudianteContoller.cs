using Microsoft.AspNetCore.Mvc;
using EscuelaPrueba.Core.DTOs;
using EscuelaPrueba.Core.Interface;
using EscuelaPrueba.Core;
using EscuelaPrueba.Infraestructure;
using AutoMapper;
using EscuelaPrueba.Infraestructure.Data;
using Microsoft.Extensions.Hosting;

namespace EscuelaPrueba.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstudianteContoller : Controller
    {
        private IEstudiantesRepository _estudiantesRepository;

        private readonly IMapper _mapper;

        public EstudianteContoller(IEstudiantesRepository estudiantesRepository, IMapper mapper)
        {
            _estudiantesRepository = estudiantesRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetEstudiante()
        { 
            var estudiantes = await _estudiantesRepository.GetEstudiantes();
            
            var estudiantesDto = _mapper.Map<IEnumerable<EstudianteDto>>(estudiantes);

            return (Ok(estudiantesDto));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetEstudianteId(int id)
        {

            var estudiantes = await _estudiantesRepository.GetEstudiantesId(id);

            var Estudiantesdto = _mapper.Map<EstudianteDto>(estudiantes);

            return Ok(Estudiantesdto);
        }
        [HttpPost]
        public async Task<IActionResult> InsetEstudiantes(Estudiante newEstudiante)
        {
            await _estudiantesRepository.PostEstudiantes(newEstudiante);

            EstudianteDto newEstudianteDto = _mapper.Map<EstudianteDto>(newEstudiante);

            return Ok(newEstudianteDto);
        }
    }
}
