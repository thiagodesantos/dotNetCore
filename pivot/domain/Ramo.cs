using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using Pivot.Domain.Infraestrutura;

namespace Pivot.Domain
{
    public class Ramo : Entity
    {
        public string Descricao { get; set; }
        [ForeignKey("RamoId")]
        public virtual ICollection<Atividade> Atividades { get; set; }
    }
}
