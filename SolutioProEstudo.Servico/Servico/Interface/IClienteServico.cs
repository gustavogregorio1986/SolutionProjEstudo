using SolutioProEstudo.Dominio.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutioProEstudo.Servico.Servico.Interface
{
    public interface IClienteServico
    {
        void AdicionarCliente(Cliente cliente);

        List<Cliente> ListarClientes();
    }
}
