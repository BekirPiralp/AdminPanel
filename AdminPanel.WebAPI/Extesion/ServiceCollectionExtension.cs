using AdminPanel.DataAccessLayer.Concrete.EntityFramework;
using Microsoft.EntityFrameworkCore;

namespace AdminPanel.WebAPI.Extesion
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddConnectionString(this IServiceCollection service,WebApplicationBuilder builder)
        {
            "".setConnectionString(builder.Configuration.GetConnectionString("Varsayilan"));
            
            service.AddDbContext<EfContext>(op=>op.UseSqlServer("".getConnectionString()));
            return service;
        }

    }
}
