using Pivot.Domain.Infraestrutura;

namespace Pivot.Domain
{
    public class Estado : Entity
    {
        public string Descricao { get; set; }
        public string Sigla { get; set; }
    }
}