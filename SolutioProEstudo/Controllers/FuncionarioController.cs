using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SolutioProEstudo.Data.DTO;
using SolutioProEstudo.Dominio.Dominio;
using SolutioProEstudo.Servico.Servico;
using SolutioProEstudo.Servico.Servico.Interface;

namespace SolutioProEstudo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FuncionarioController : ControllerBase
    {
        private readonly IFuncionarioServico _funcionarioServico;

        public FuncionarioController(IFuncionarioServico funcionarioServico)
        {
            _funcionarioServico = funcionarioServico;
        }

        [HttpPost]
        [Route("AdicionarFuncionario")]
        public JsonResult AdicionarFuncionario(Funcionario funcionario)
        {
            try
            {
                FuncionarioDTO funcionarioDTO = new FuncionarioDTO();
                funcionario.NomeFuncionario = funcionarioDTO.NomeFuncionario;
                funcionario.EmailFuncionario = funcionarioDTO.EmailFuncionario;
                funcionario.Sexo = funcionarioDTO.Sexo;
                funcionario.Salario = funcionarioDTO.Salario;

                _funcionarioServico.AdicionarFuncionario(funcionario);
            }
            catch (Exception ex)
            {
                throw new Exception("erro: " + ex.Message);
            }

            return new JsonResult(funcionario);
        }

        [HttpGet]
        [Route("ListarFuncionarios")]
        public List<Funcionario> ListarFuncionarios()
        {
            List<Funcionario> listarFuncionarios = _funcionarioServico.ListarFuncionarios();
            return listarFuncionarios;
        }
    }
}
