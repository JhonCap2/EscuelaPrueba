using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace EscuelaPrueba.Infraestructure.Data;

public partial class Curso
{
    public int Id { get; set; }

    public int IdEstudiante { get; set; }

    public int IdProfesor { get; set; }

    public string? Aula { get; set; }

    [JsonIgnore]
    public virtual Estudiante? IdEstudianteNavigation { get; set; }
    [JsonIgnore]
    public virtual Profesor? IdProfesorNavigation { get; set; }
}
