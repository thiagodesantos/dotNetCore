using Pivot.Domain;
using Pivot.Service.Infraestrutura;

namespace Pivot.Service.Interfaces
{
    public interface IMarca : IService<Marca>
    {
        void Agrupar(Marca m1, Marca m2);
    }
}