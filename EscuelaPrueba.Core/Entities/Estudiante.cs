using System;
using System.Collections.Generic;

namespace EscuelaPrueba.Infraestructure.Data;

public partial class Estudiante
{
    public int Id { get; set; }

    public string? Nombres { get; set; }

    public string? Apellidos { get; set; }

    public decimal? Edad { get; set; }

    public string? Direccion { get; set; }

    public string? Telefono { get; set; }

    public virtual ICollection<Curso> Cursos { get; } = new List<Curso>();
}
