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
    public class ClienteServico : IClienteServico
    {
        private readonly IClienteRepository _clienteRepository;

        public ClienteServico(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public void AdicionarCliente(Cliente cliente)
        {
            _clienteRepository.AdicionarCliente(cliente);
        }

        public List<Cliente> ListarClientes()
        {
            return _clienteRepository.ListarClientes();
        }
    }
}
