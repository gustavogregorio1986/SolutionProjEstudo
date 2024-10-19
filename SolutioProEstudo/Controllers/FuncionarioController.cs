using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
    }
}
