using EscuelaPrueba.Infraestructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscuelaPrueba.Core.Interface
{
    public interface IEstudiantesRepository
    {
        Task<IEnumerable<Estudiante>> GetEstudiantes();
        Task<Estudiante> GetEstudiantesId(int id);
        Task PostEstudiantes(Estudiante newEstudiante);    
    }
}
