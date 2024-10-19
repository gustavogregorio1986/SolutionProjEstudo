using SolutioProEstudo.Dominio.Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutioProEstudo.Data.DTO
{
    public class EmpresaDTO
    {
        public Guid Id { get; set; }

        public string? NomeEmpresa { get; set; }

        public string? Cnpj { get; set; }

        public string? Setor { get; set; }

        public Funcionario? Funcionario { get; set; }

        public Guid Id_Funcionarioe { get; set; }
    }
}
