using System;
using System.Collections.Generic;

namespace EscuelaPrueba.Infraestructure.Data;

public partial class Curso
{
    public int Id { get; set; }

    public int IdEstudiante { get; set; }

    public int IdProfesor { get; set; }

    public string? Aula { get; set; }

    public virtual Estudiante IdEstudianteNavigation { get; set; } = null!;

    public virtual Profesor IdProfesorNavigation { get; set; } = null!;
}
