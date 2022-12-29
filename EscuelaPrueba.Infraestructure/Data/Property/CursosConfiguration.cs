using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace EscuelaPrueba.Infraestructure.Data.Property
{
    public class CursosConfiguration : IEntityTypeConfiguration<Curso>
    {
        public void Configure(EntityTypeBuilder<Curso> builder)
        {

            builder.HasKey(e => e.Id).HasName("Id");

            builder.ToTable("Curso");

            builder.Property(e => e.Aula)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Aula");

            builder.HasOne(d => d.IdEstudianteNavigation).WithMany(p => p.Cursos)
                    .HasForeignKey(d => d.IdEstudiante)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("IdEstudiante");

            builder.HasOne(d => d.IdProfesorNavigation).WithMany(p => p.Cursos)
                    .HasForeignKey(d => d.IdProfesor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("IdProfesor");
            
        }
    }
}
