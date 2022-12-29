using AutoMapper;
using EscuelaPrueba.Core.DTOs;
using EscuelaPrueba.Core.Interface;
using EscuelaPrueba.Infraestructure.Data;
using Microsoft.AspNetCore.Mvc;

namespace EscuelaPrueba.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfesorController : Controller
    {
        private IProfesorRepository _profesorRepository;

        private readonly IMapper _mapper;

        public ProfesorController(IProfesorRepository profesorRepository, IMapper mapper)
        {
            _profesorRepository = profesorRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetProfesors()
        {
            var profesors = await _profesorRepository.GetProfesors();

            var profesorsDto = _mapper.Map<IEnumerable<ProfesorDto>>(profesors);

            return (Ok(profesorsDto));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetProfesorId(int id)
        {

            var profesor = await _profesorRepository.GetProfesorId(id);

            var profesorDto = _mapper.Map<ProfesorDto>(profesor);

            return Ok(profesorDto);
        }
        [HttpPost]
        public async Task<IActionResult> InsertProfesor(Profesor newProfesore)
        {
            await _profesorRepository.PostProfesors(newProfesore);

            ProfesorDto newProfesoresDto = _mapper.Map<ProfesorDto>(newProfesore);

            return Ok(newProfesoresDto);
        }
    }
}
