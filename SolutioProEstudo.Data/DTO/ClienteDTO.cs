using SolutioProEstudo.Dominio.Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutioProEstudo.Data.DTO
{
    public class ClienteDTO
    {
        public Guid Id { get; set; }

        public string? NomeCliente { get; set; }

        public string? Setor { get; set; }

        public string? Tipo { get; set; }

        public Empresa? Empresa { get; set; }

        public Guid Id_Empresa { get; set; }
    }
}
