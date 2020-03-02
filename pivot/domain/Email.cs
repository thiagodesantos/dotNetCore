using System.ComponentModel.DataAnnotations.Schema;
using Pivot.Domain.Infraestrutura;

namespace Pivot.Domain
{
    public class Email : Entity
    {
        public string Endereco { get; set; }
        [ForeignKey("Contato")]
        public long ContatoId { get; set; }
        public virtual Contato Contato { get; set; }
    }
}