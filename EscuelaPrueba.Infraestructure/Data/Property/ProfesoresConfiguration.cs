using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscuelaPrueba.Infraestructure.Data.Property
{
    public class ProfesoresConfiguration : IEntityTypeConfiguration<Profesor>
    {
        public void Configure(EntityTypeBuilder<Profesor> builder)
        {
            builder.HasKey(e => e.Id).HasName("Id");

            builder.ToTable("Profesor");

            builder.Property(e => e.Apellidos)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Apellidos");
            builder.Property(e => e.Direccion)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("Direccion");
            builder.Property(e => e.Edad)
                .HasColumnType("numeric(3, 0)")
                .HasColumnName("Edad");
            builder.Property(e => e.Materia)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Materia");
            builder.Property(e => e.Nombres)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Nombres");
            builder.Property(e => e.Telefono)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Telefono");
        }
    }
}
