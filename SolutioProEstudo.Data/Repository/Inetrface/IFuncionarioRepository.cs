using SolutioProEstudo.Dominio.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutioProEstudo.Data.Repository.Inetrface
{
    public interface IFuncionarioRepository
    {
        void AdicionarFuncionario(Funcionario funcionario);

        List<Funcionario> ListarFuncionarios();
    }
}
