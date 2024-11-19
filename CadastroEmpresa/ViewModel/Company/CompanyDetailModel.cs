using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CadastroEmpresa.Models.Company
{
    public class CompanyDetailModel
    {
        public int Id { get; set; }
        public string Cnpj { get; set; }
        public string Nome { get; set; }
        public string País { get; set; }
        public string Endereço { get; set; }
        public decimal Numero { get; set; }
        public decimal Cep { get; set; }
        public bool Active { get; set; }
    }
}