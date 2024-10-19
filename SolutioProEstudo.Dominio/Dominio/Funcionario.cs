using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SolutioProEstudo.Dominio.Dominio
{
    [Table("tb_Funcionario")]
    public class Funcionario
    {
        [Key]
        public Guid Id { get; set; }

        public string? NomeFuncionario { get; set; }

        public string? EmailFuncionario { get; set; }

        public string? Sexo { get; set; }

        public double Salario { get; set; }
    }
}
