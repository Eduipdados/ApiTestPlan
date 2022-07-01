using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api.Domain.Models
{
    public class Produto
    {
        public Produto()
        {
        }
        public int IdProduto { get; set; }
        public string Nome { get; set; }
        public string GrupoQuimico { get; set; }
        public string PrincipioAtivo { get; set; }
        public string Concentracao { get; set; }
        public string RegistroSaude { get; set; }
    }
}
