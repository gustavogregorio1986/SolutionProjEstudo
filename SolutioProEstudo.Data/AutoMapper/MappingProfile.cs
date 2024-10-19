using AutoMapper;
using SolutioProEstudo.Data.DTO;
using SolutioProEstudo.Dominio.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutioProEstudo.Data.AutoMapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Cliente, ClienteDTO>();
            CreateMap<Funcionario, FuncionarioDTO>();
            CreateMap<Empresa, EmpresaDTO>();
        }
    }
}
