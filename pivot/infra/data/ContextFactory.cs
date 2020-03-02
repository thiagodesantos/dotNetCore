using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Pivot.Infra.Data
{
    public class ContextFactory : IDesignTimeDbContextFactory<Context>
    {
        public Context CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<Context>();
            optionsBuilder.UseSqlServer("Server=str_Endereco_Servidor;Database=CorePivot_thiago;User Id=log_user;Password=str_senha;");

            return new Context(optionsBuilder.Options);
        }
    }
}