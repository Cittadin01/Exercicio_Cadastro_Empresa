using CadastroEmpresa.Models.Company;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CadastroEmpresa.DataBase
{
    public class CompanyDbContext : 
    {
        public CompanyDbContext() : base("")
        {
        }

        public class DbSet<Company> Company { get; set; }
        public object Conventions { get; private set; }
    }
}
