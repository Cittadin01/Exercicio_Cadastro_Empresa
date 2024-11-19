using System;

namespace CadastroEmpresa.ViewModel.Company
{
    public class CompanyIndexModel
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