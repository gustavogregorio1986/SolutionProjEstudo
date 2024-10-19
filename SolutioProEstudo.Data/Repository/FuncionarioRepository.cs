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
    public class FuncionarioRepository : IFuncionarioRepository
    {
        private readonly SolutioProjEstudoContxto _db;

        public FuncionarioRepository(SolutioProjEstudoContxto db)
        {
            _db = db;   
        }

        public void AdicionarFuncionario(Funcionario funcionario)
        {
            _db.Funcionarios.Add(funcionario);
            _db.SaveChanges();
        }

        public List<Funcionario> ListarFuncionarios()
        {
            return _db.Funcionarios.ToList();
        }
    }
}
