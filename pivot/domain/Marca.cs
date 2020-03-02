using System;
using System.ComponentModel.DataAnnotations.Schema;
using Pivot.Domain.Infraestrutura;

namespace Pivot.Domain
{
    public class Marca : Entity
    {
        public string Descricao { get; set; }
        [ForeignKey("Atividade")]
        public long AtividadeId { get; set; }
        public virtual Atividade Atividade { get; set; }
        [ForeignKey("Representante")]
        public long RepresentanteId { get; set; }
        public virtual Marca Representante { get; set; }
        public Enums.PricePoint PricePoint { get; set; }
        public Enums.FaixaEtaria FaixaEtaria { get; set; }
        public Enums.Abrangencia Abrangencia { get; set; }
        public Enums.ModeloOperacional ModeloOperacional { get; set; }
        public string Url { get; set; }
        public string Logo { get; set; }

        [ForeignKey("MarcaAgrupada")]
        public long MarcaAgrupadaId { get; set; }
        public virtual Marca MarcaAgrupada { get; set; }
    }
}
