using EscuelaPrueba.Core.Interface;
using EscuelaPrueba.Infraestructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscuelaPrueba.Infraestructure.Repositories
{
    public class CursoRepository : ICusosRepository
    {
        private readonly EscuelaContext _context;

        public CursoRepository(EscuelaContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Curso>> GetCursos()
        {
            var cursos = await _context.Cursos.ToListAsync();

            return cursos;
        }

        public async Task<Curso> GetCursosId(int id)
        {
            var curso = await _context.Cursos.FirstOrDefaultAsync(x => x.Id == id);

            return curso;
        }
        
        public async Task PostCursos(Curso newCurso)
        {
            await _context.Cursos.AddAsync(newCurso);

            _context.SaveChanges();
        }
    }
}
