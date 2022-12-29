using EscuelaPrueba.Core.Interface;
using EscuelaPrueba.Infraestructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscuelaPrueba.Infraestructure.Repositories
{
    public class EstudianteRepository : IEstudiantesRepository
    {
        private readonly EscuelaContext _context;

        public EstudianteRepository(EscuelaContext context)
        {
            _context= context;
        }
        public async Task<IEnumerable<Estudiante>> GetEstudiantes()
        {
            var estudiantes = await _context.Estudiantes.ToListAsync();

            return estudiantes;
        }

        public async Task<Estudiante> GetEstudiantesId(int id)
        {
            var estudiante = await _context.Estudiantes.FirstOrDefaultAsync(x => x.Id == id);

            return estudiante;
        }

        public async Task PostEstudiantes(Estudiante newEstudiante)
        {
            await _context.Estudiantes.AddAsync(newEstudiante);

            _context.SaveChanges();
        }
    }
}
