using System;
using Pivot.Domain;
using Pivot.Service.Infraestrutura;

namespace Pivot.Service.Interfaces
{
    public interface IRamoService : IService<Ramo>
    {
        void TesteThiago(Ramo ramo);
    }
}
