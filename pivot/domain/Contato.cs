using System.ComponentModel.DataAnnotations.Schema;
using Pivot.Domain.Infraestrutura;

namespace Pivot.Domain
{
    public class Contato : Entity
    {
        public string Nome { get; set; }
        public string Cargo { get; set; }
        [ForeignKey("Cidade")]
        public long CidadeId { get; set; }
        public virtual Cidade Cidade { get; set; }
        [ForeignKey("Marca")]
        public long MarcaId { get; set; }
        public virtual Marca Marca { get; set; }
    }
}