using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SolutioProEstudo.Dominio.Dominio
{
    [Table("tb_Cliente")]
    public class Cliente
    {
        [Key]
        public Guid Id { get; set; }

        public string? NomeCliente { get; set; }

        public string? Setor { get; set; }

        public string? Tipo { get; set; }

        public Empresa? Empresa { get; set; }

        [ForeignKey("Empresa")]
        public Guid Id_Empresa { get; set; }
    }
}
