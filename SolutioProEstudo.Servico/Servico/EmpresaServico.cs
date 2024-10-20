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
    public class EmpresaServico : IEmpresaServico
    {
        private readonly IEmpresaRepository _empresaRepository;

        public EmpresaServico(IEmpresaRepository empresaRepository)
        {
            _empresaRepository = empresaRepository;
        }

        public void AdicionarEmpresa(Empresa empresa)
        {
            _empresaRepository.AdicionarEmpresa(empresa);
        }

        public List<Empresa> ListarEmpresas()
        {
            return _empresaRepository.ListarEmpresas();
        }
    }
}
