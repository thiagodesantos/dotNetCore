using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Pivot.Domain.Infraestrutura;
using Pivot.Infra.Data;

namespace Pivot.Service.Infraestrutura
{
    public class BaseService<T> : IService<T> where T : Entity
    {
        public BaseService() { }

        public IEnumerable<T> SelecionarTodos()
        {
            return this.Selecionar(t => true);
        }

        public IEnumerable<T> Selecionar(Expression<Func<T, bool>> filtro)
        {
            return RepositoryFactory.GetInstancia().Get<T>().Selecionar(filtro);
        }

        public T Selecionar(long id)
        {
            return this.Selecionar(e => e.Id == id).FirstOrDefault();
        }

        public T Remover(long id)
        {
            return RepositoryFactory.GetInstancia().Get<T>().Remover(id);
        }

        public T Salvar(T entity)
        {
            return RepositoryFactory.GetInstancia().Get<T>().Salvar(entity);
        }

        public ICollection<T> Salvar(ICollection<T> entities)
        {
            return RepositoryFactory.GetInstancia().Get<T>().Salvar(entities);
        }

        public void Completar()
        {
            RepositoryFactory.GetInstancia().Get<T>().Completar();
        }
    }
}
