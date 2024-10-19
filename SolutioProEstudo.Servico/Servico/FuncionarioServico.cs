using SolutioProEstudo.Data.Repository.Inetrface;
using SolutioProEstudo.Dominio.Dominio;
using SolutioProEstudo.Servico.Servico.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutioProEstudo.Servico.Servico
{
    public class FuncionarioServico : IFuncionarioServico
    {
        private readonly IFuncionarioRepository _funcionarioRepository;

        public FuncionarioServico(IFuncionarioRepository funcionarioRepository)
        {
            _funcionarioRepository = funcionarioRepository;
        }

        public void AdicionarFuncionario(Funcionario funcionario)
        {
            _funcionarioRepository.AdicionarFuncionario(funcionario);
        }

        public List<Funcionario> ListarFuncionarios()
        {
            return _funcionarioRepository.ListarFuncionarios();
        }
    }
}
