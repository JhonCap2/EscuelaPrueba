using EscuelaPrueba.Infraestructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscuelaPrueba.Core.Interface
{
    public interface ICusosRepository
    {
        Task<IEnumerable<Curso>> GetCursos();
        Task<Curso> GetCursosId(int id);
        Task PostCursos(Curso newCurso);
    }
}
