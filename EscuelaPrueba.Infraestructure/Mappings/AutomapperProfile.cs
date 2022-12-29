using AutoMapper;
using EscuelaPrueba.Core.DTOs;
using EscuelaPrueba.Infraestructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscuelaPrueba.Infraestructure.Mappings
{
    public class AutomapperProfile : Profile
    {
        public AutomapperProfile() 
        {
            CreateMap<Curso, CursoDto>();
            CreateMap<CursoDto, Curso>();

            CreateMap<Estudiante, EstudianteDto>();
            CreateMap<EstudianteDto, Estudiante>();

            CreateMap<Profesor, ProfesorDto>();
            CreateMap<ProfesorDto, Profesor>();

        }
        
    }
}
