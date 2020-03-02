using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Pivot.Domain.Infraestrutura;

namespace Pivot.Service.Infraestrutura
{
    public interface IService<T> where T : Entity
    {
        IEnumerable<T> SelecionarTodos();
        IEnumerable<T> Selecionar(Expression<Func<T, bool>> filtro);
        T Selecionar(long id);
        T Salvar(T obj);
        ICollection<T> Salvar(ICollection<T> lst);
        T Remover(long id);
    }
}