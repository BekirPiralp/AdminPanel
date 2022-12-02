using AdminPanel.EntityLayer.Concrete.Other.Ybs_Filo;
using Microsoft.EntityFrameworkCore;
using Oracle.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using AdminPanel.AppSettings;

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
            optionsBuilder.UseOracle(
                AppSettingsConfiguration.Create().Configuration[AppSettingsConfigurationNames.OracleDbString]
                ,op=>op.UseOracleSQLCompatibility(
                    AppSettingsConfiguration.Create().Configuration[AppSettingsConfigurationNames.OracleSqlComponity]
                    ));

        }
        public DbSet<TEMP_SOSYALYARDIM3> TEMP_SOSYALYARDIM3 { get; set; }
    }
}
