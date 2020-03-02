using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Pivot.Domain.Infraestrutura;

namespace Pivot.Infra.Data
{
    public interface IRepository<T> where T : Entity
    {
        T Salvar(T entity);
        ICollection<T> Salvar(ICollection<T> entities);
        T Remover(long Id);
        IQueryable<T> Selecionar(long Id);
        IQueryable<T> Selecionar(Expression<Func<T, bool>> filtro);
        void Completar();
    }
}