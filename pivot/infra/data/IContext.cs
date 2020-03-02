using System;
using Microsoft.EntityFrameworkCore;
using Pivot.Domain.Infraestrutura;

namespace Pivot.Infra.Data
{
    public interface IContext
    {
        DbSet<T> GetDbSet<T>() where T : Entity;
        int SaveChanges();
    }
}
