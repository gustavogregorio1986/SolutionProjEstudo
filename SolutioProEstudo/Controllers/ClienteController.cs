using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SolutioProEstudo.Servico.Servico.Interface;

namespace SolutioProEstudo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly IClienteServico _clienteServico;

        public ClienteController(IClienteServico clienteServico)
        {
            _clienteServico = clienteServico;
        }
    }
}
