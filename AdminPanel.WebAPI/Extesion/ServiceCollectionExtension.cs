using AdminPanel.DataAccessLayer.Concrete.EntityFramework;
using Microsoft.EntityFrameworkCore;

namespace AdminPanel.WebAPI.Extesion
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddConnectionString(this IServiceCollection service,WebApplicationBuilder builder)
        {
            service.AddDbContext<EfContext>(op=>op.UseSqlServer(builder.Configuration.GetConnectionString("Varsayilan")));
            return service;
        }

    }
}
