using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SolutioProEstudo.Data.DTO;
using SolutioProEstudo.Dominio.Dominio;
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

        [HttpPost]
        [Route("AdicionarCliente")]
        public JsonResult AdicionarCliente(Cliente cliente)
        {
            try
            {
                ClienteDTO clienteDTO = new ClienteDTO();
                cliente.NomeCliente = clienteDTO.NomeCliente;
                cliente.Setor = clienteDTO.Setor;
                cliente.Tipo = clienteDTO.Tipo;

                _clienteServico.AdicionarCliente(cliente);
            }
            catch (Exception ex)
            {
                throw new Exception("erro: " + ex.Message);
            }

            return new JsonResult(cliente);
        }

        [HttpGet]
        [Route("ListarClientes")]
        public List<Cliente> ListarClientes()
        {
            List<Cliente> listarClientes = _clienteServico.ListarClientes();
            return listarClientes;
        }
    }
}
