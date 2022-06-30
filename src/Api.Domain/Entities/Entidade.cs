using Api.Domain.Entities;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class Entidade : BaseEntity
    {
        [Key]
        public int IdEntidade { get; set; }
        public string Nome { get; set; }
        public string Cnpj { get; set; }

    }
}
