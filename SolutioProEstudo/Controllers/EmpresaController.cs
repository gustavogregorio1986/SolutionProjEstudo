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
    public class EmpresaController : ControllerBase
    {
        private readonly IEmpresaServico _empresaServico;

        public EmpresaController(IEmpresaServico empresaServico)
        {
            _empresaServico = empresaServico;
        }

        [HttpPost]
        [Route("AdicionarEmpresa")]
        public JsonResult AdicionarEmpresa(Empresa empresa)
        {
            try
            {
                EmpresaDTO empresaDTO = new EmpresaDTO();
                empresa.NomeEmpresa = empresaDTO.NomeEmpresa;
                empresa.Cnpj = empresaDTO.Cnpj;
                empresa.Setor = empresaDTO.Setor;

                _empresaServico.AdicionarEmpresa(empresa);
            }
            catch (Exception ex)
            {
                throw new Exception("erro: " + ex.Message);
            }

            return new JsonResult(empresa);
        }

        [HttpGet]
        [Route("ListarEmpresas")]
        public List<Empresa> ListarEmpresas()
        {
            List<Empresa> listarEmpresas = _empresaServico.ListarEmpresas();
            return listarEmpresas;
        }
    }
}
