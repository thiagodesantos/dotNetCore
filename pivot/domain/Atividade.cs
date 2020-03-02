using System;
using System.ComponentModel.DataAnnotations.Schema;
using Pivot.Domain.Infraestrutura;

namespace Pivot.Domain
{
    public class Atividade : Entity
    {
        public string Descricao { get; set; }
        [ForeignKey("Ramo")]
        public long RamoId { get; set; }
        public virtual Ramo Ramo { get; set; }
    }
}
