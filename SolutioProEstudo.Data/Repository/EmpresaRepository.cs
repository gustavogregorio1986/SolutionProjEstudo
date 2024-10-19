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
    public class EmpresaRepository : IEmpresaRepository
    {
        private readonly SolutioProjEstudoContxto _db;

        public EmpresaRepository(SolutioProjEstudoContxto db)
        {
            _db = db;
        }

        public void AdicionarEmpresa(Empresa empresa)
        {
            _db.Empresas.Add(empresa);
            _db.SaveChanges();
        }

        public List<Empresa> ListarEmpresas()
        {
            return _db.Empresas.ToList();
        }
    }
}
