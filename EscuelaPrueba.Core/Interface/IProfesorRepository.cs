using EscuelaPrueba.Infraestructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscuelaPrueba.Core.Interface
{
    public interface IProfesorRepository
    {
        Task<IEnumerable<Profesor>> GetProfesors();
        Task<Profesor> GetProfesorId(int id);
        Task PostProfesors(Profesor newProfesor);
    }
}
