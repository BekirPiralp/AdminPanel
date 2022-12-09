using AdminPanel.AppSettings;
using AdminPanel.EntityLayer.Concrete.Other.Product;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace AdminPanel.DataAccessLayer.Concrete.EntityFramework
{
    public class EfContextMsSql : DbContext
    {
        public EfContextMsSql() : base()
        {

        }

        public EfContextMsSql(DbContextOptions<EfContextMsSql> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                AppSettingsConfiguration.Create().Configuration.GetConnectionString(
                AppSettingsConfigurationNames.MsSql
                ));

            base.OnConfiguring(optionsBuilder);
        }

        DbSet<Product> Product { get; set; }
    }
}
