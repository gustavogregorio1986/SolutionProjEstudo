using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutioProEstudo.Data.DTO
{
    public class FuncionarioDTO
    {
        public Guid Id { get; set; }

        public string? NomeFuncionario { get; set; }

        public string? EmailFuncionario { get; set; }

        public string? Sexo { get; set; }

        public double Salario { get; set; }
    }
}
