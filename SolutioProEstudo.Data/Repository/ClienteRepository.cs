using SolutioProEstudo.Data.Contexto;
using SolutioProEstudo.Data.Repository.Inetrface;
using SolutioProEstudo.Dominio.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutioProEstudo.Data.Repository
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly SolutioProjEstudoContxto _db;

        public ClienteRepository(SolutioProjEstudoContxto db)
        {
            _db = db;
        }

        public void AdicionarCliente(Cliente cliente)
        {
            _db .Add(cliente);
            _db.SaveChanges();
        }

        public List<Cliente> ListarClientes()
        {
            return _db.Clientes.ToList();
        }
    }
}
