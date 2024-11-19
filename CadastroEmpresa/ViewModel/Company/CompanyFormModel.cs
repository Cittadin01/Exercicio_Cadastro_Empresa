using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CadastroEmpresa.ViewModel.Company
{
    public class CompanyFormModel
    {
        public int Id { get; set; }

        [Required]
        [StringLength(14)]
        public string Cnpj { get; set; }

        [Required]
        [StringLength(100)]
        public string Nome { get; set; }

        [Required]
        [StringLength(100)]
        public string País { get; set; }

        [Required]
        [StringLength(100)]
        public string Endereço { get; set; }

        [Required]
        [StringLength(10)]
        public decimal Numero { get; set; }

        [Required]
        [StringLength(8)]
        public decimal Cep { get; set; }

        public bool Active { get; set; }
    }
}