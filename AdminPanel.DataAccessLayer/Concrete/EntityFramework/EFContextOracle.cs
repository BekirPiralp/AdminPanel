using AdminPanel.EntityLayer.Concrete.Other.Ybs_Filo;
using Microsoft.EntityFrameworkCore;
using Oracle.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace AdminPanel.DataAccessLayer.Concrete.EntityFramework
{
    public class EFContextOracle:DbContext
    {
        public EFContextOracle(): base()
        {

        }

        public EFContextOracle(DbContextOptions<EFContextOracle> options) : base(options)
        {
            
        }

       protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            //var configuration = new ConfigurationBuilder()
            //    .SetBasePath(Directory.GetCurrentDirectory())
            //    .AddJsonFile("appsettings.json")
            //    .Build();


            //var connectionString = configuration.GetConnectionString("OracleString");
            //optionsBuilder.UseSqlServer(connectionString);
            //optionsBuilder.UseOracle(connectionString);



             optionsBuilder.UseOracle("".getConnectionString());

        }
        public DbSet<TEMP_SOSYALYARDIM3> TEMP_SOSYALYARDIM3 { get; set; }
    }
}
