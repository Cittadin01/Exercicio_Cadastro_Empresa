using CadastroEmpresa.DataBase;
using CadastroEmpresa.Models;
using CadastroEmpresa.Models.Company;
using System;
using System.Collections.Generic;

namespace CadastroEmpresa.Database
{
    public class CompanyInitializer
    {
        public void Seed(CompanyDbContext context)
        {
            var company = new List<Company>
            {
                new Company
                {
                    Id = 1,
                    Cnpj = "63095677000170",
                    Nome = "Empresa Teste",
                    País = "Brazil",
                    Endereço = "Rua 123",
                    Numero = 789,
                    Cep = 88840033,
                    Active = true,
                },
                new Company
                {
                    Id = 2,
                    Cnpj = "12395417000152",
                    Nome = "Narwal",
                    País = "Brazil",
                    Endereço = "Avenida Teste",
                    Numero = 528,
                    Cep = 88810022,
                    Active = true,
                }
            };
        }
    }
}