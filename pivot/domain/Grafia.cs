using System;
using System.ComponentModel.DataAnnotations.Schema;
using Pivot.Domain.Infraestrutura;

namespace Pivot.Domain
{
    class Grafia : Entity
    {
        public string Descricao { get; set; }
        [ForeignKey("Marca")]
        public long MarcaId { get; set; }
        public virtual Marca Marca { get; set; }
    }
}