using System;
using System.Collections.Generic;
using EscuelaPrueba.Infraestructure.Data.Property;
using Microsoft.EntityFrameworkCore;
using EscuelaPrueba.Core.Interface;


namespace EscuelaPrueba.Infraestructure.Data;

public partial class EscuelaContext : DbContext
{
    public EscuelaContext()
    {
    }

    public EscuelaContext(DbContextOptions<EscuelaContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Curso> Cursos { get; set; }

    public virtual DbSet<Estudiante> Estudiantes { get; set; }

    public virtual DbSet<Profesor> Profesors { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new CursosConfiguration());
        modelBuilder.ApplyConfiguration(new ProfesoresConfiguration());
        modelBuilder.ApplyConfiguration(new EstudiantesConfiguration());

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
