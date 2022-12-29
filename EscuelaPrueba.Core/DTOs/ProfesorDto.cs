using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscuelaPrueba.Core.DTOs
{
    public class ProfesorDto
    {
        public int Id { get; set; }

        public string? Nombres { get; set; }

        public string? Apellidos { get; set; }

        public decimal? Edad { get; set; }

        public string? Direccion { get; set; }

        public string? Telefono { get; set; }

        public string? Materia { get; set; }
    }
}
