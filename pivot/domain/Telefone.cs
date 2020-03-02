using System.ComponentModel.DataAnnotations.Schema;
using Pivot.Domain.Infraestrutura;

namespace Pivot.Domain
{
    public class Telefone : Entity
    {
        public string Numero { get; set; }
        [ForeignKey("Contato")]
        public long ContatoId { get; set; }
        public virtual Contato Contato { get; set; }
    }
}