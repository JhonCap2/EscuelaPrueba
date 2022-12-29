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
    public class ProfesorRepository : IProfesorRepository
    {
        private readonly EscuelaContext _context;

        public ProfesorRepository(EscuelaContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Profesor>> GetProfesors()
        {
            var profesores = await _context.Profesors.ToListAsync();

            return profesores;
        }

        public async Task<Profesor> GetProfesorId(int id)
        {
            var profesorId = await _context.Profesors.FirstOrDefaultAsync(x => x.Id == id);

            return profesorId;
        }

        public async Task PostProfesors(Profesor newProfesor)
        {
            await _context.Profesors.AddAsync(newProfesor);

            _context.SaveChanges();
        }
    }
}
