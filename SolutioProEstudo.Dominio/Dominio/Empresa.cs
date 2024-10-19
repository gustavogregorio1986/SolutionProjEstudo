using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SolutioProEstudo.Dominio.Dominio
{
    [Table("tb_Empresa")]
    public class Empresa
    {
        [Key]
        public Guid Id { get; set; }

        public string? NomeEmpresa { get; set; }

        public string? Cnpj { get; set; }

        public string? Setor { get; set; }

        public Funcionario? Funcionario { get; set; }

        [ForeignKey("Funcionario")]
        public Guid Id_Funcionarioe { get; set; }
    }
}
