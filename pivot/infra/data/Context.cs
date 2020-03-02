using System;
using System.Linq;
using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Pivot.Domain;
using Pivot.Domain.Infraestrutura;

namespace Pivot.Infra.Data
{
    public class Context : DbContext, IContext
    {
        public Context(DbContextOptions<Context> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var baseType = typeof(Entity);

            foreach (var type in Assembly.GetAssembly(baseType).GetTypes().Where(t => t.IsSubclassOf(baseType)))
            {
                modelBuilder.Entity(type);
            }

            base.OnModelCreating(modelBuilder);

            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }
        }

        private void Seeding(ModelBuilder modelBuilder)
        {
            // modelBuilder.Entity<Ramo>().HasData(new Ramo { });
        }

        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries())
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property("DataAlteracao").CurrentValue =
                        entry.Property("DataCriacao").CurrentValue =
                        DateTime.Now;
                    entry.Property("UsuarioAlteracaoId").CurrentValue = entry.Property("UsuarioCriacaoId").CurrentValue;
                    entry.Property("UsuarioAlteracaoLogin").CurrentValue = entry.Property("UsuarioCriacaoLogin").CurrentValue;
                    entry.Property("Ativo").CurrentValue = true;
                }

                if (entry.State == EntityState.Modified)
                {
                    entry.Property("DataAlteracao").CurrentValue = DateTime.Now;
                    entry.Property("DataCriacao").IsModified = false;
                    entry.Property("UsuarioCriacaoId").IsModified = false;
                    entry.Property("UsuarioCriacaoLogin").IsModified = false;
                }
            }

            return base.SaveChanges();
        }

        public DbSet<TEntity> GetDbSet<TEntity>() where TEntity : Entity
        {
            return this.Set<TEntity>();
        }
    }
}