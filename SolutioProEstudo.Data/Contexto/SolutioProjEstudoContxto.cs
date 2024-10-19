using Microsoft.EntityFrameworkCore;
using SolutioProEstudo.Dominio.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutioProEstudo.Data.Contexto
{
    public class SolutioProjEstudoContxto : DbContext
    {
        public SolutioProjEstudoContxto(DbContextOptions options)
            :base(options) 
        {
                
        }

        public DbSet<Funcionario> Funcionarios { get; set; }

        public DbSet<Empresa> Empresas { get; set; }

        public DbSet<Cliente> Clientes { get; set; }
    }
}
