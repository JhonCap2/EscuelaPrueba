using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscuelaPrueba.Core.DTOs
{
    public class CursoDto
    {
        public int Id { get; set; }

        public int IdEstudiante { get; set; }

        public int IdProfesor { get; set; }

        public string? Aula { get; set; }
    }
}
