using AdminPanel.EntityLayer.Concrete.Other.ArabaKismi;
using AdminPanel.EntityLayer.Concrete.Other.AuthenticationKismi;
using AdminPanel.EntityLayer.Concrete.Other.BolumBilgileri;
using AdminPanel.EntityLayer.Concrete.Other.FirmaKismi;
using AdminPanel.EntityLayer.Concrete.Other.HakkindaKismi;
using AdminPanel.EntityLayer.Concrete.Other.HizmetKismi;
using AdminPanel.EntityLayer.Concrete.Other.IletisimKismi;
using AdminPanel.EntityLayer.Concrete.Other.IpucuKismi;
using AdminPanel.EntityLayer.Concrete.Other.LogoKismi;
using AdminPanel.EntityLayer.Concrete.Other.MesajKismi;
using AdminPanel.EntityLayer.Concrete.Other.MusteriKismi;
using AdminPanel.EntityLayer.Concrete.Other.PaketKismi;
using AdminPanel.EntityLayer.Concrete.Other.PersonelKismi;

using Microsoft.EntityFrameworkCore;

namespace AdminPanel.DataAccessLayer.Concrete.EntityFramework
{
    [Serializable]
    public class EfContext : DbContext
    {

        public EfContext() : base()
        {

        }

        public EfContext(DbContextOptions<EfContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder//.UseLazyLoadingProxies()
                .UseSqlServer("".getConnectionString());

            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<Araba> Arabalar { get; set; }
        public DbSet<ArabaBolumBilgisi> ArabaBolumBilgileri { get; set; }
        public DbSet<ArabaKasaTip> ArabaKasaTipleri { get; set; }
        public DbSet<ArabaMarka> ArabaMarkalari { get; set; }
        public DbSet<ArabaAitOzellik> ArabayaAitOzellikler { get; set; }
        public DbSet<ArabaOzellik> ArabaOzellikleri { get; set; }
        public DbSet<ArabaTip> ArabaTipleri { get; set; }
        public DbSet<ArabaVitesTip> ArabaVitesTipleri { get; set; }

        public DbSet<Bayi> Bayiler { get; set; }
        public DbSet<BayiYonetici> BayiYoneticileri { get; set; }
        public DbSet<Firma> Firmalar { get; set; }
        public DbSet<FirmaSahip> FirmaSahipleri { get; set; }

        public DbSet<GaleriBolumBilgisi> GaleriBolumBilgileri { get; set; }
        public DbSet<HakkindaBolumBilgisi> HakkindaBolumBilgileri { get; set; }
        public DbSet<HakkindaIcerik> HakkindaIcerikler { get; set; }
        public DbSet<HakkindaReklam> HakkindaReklamlar { get; set; }

        public DbSet<Hizmet> Hizmetler { get; set; }
        public DbSet<HizmetAlt> HizmetAltlar { get; set; }
        public DbSet<HizmetAltOzellik> HizmetAltOzellikler { get; set; }
        public DbSet<HizmetBolumBilgisi> HizmetBolumBilgileri { get; set; }

        public DbSet<Iletisim> Iletisimler { get; set; }
        public DbSet<IletisimBolumBilgisi> IletisimBolumBilgileri { get; set; }

        public DbSet<IpucuVeYazi> IpucuVeYazilar { get; set; }
        public DbSet<IpucuVeYaziBolumBilgisi> IpucuVeYaziBolumBilgileri { get; set; }

        public DbSet<Mesaj> Mesajlar { get; set; }
        public DbSet<Musteri> Musteriler { get; set; }

        public DbSet<Paket> Paketler { get; set; }
        public DbSet<PaketAitOzellik> PaketAitOzellikleri { get; set; }
        public DbSet<PaketBolumBilgisi> PaketBolumBilgileri { get; set; }
        public DbSet<PaketOzellik> PaketOzellikleri { get; set; }

        public DbSet<Personel> Personeller { get; set; }
        public DbSet<PersonelBolumBilgisi> PersonelBolumBilgileri { get; set; }
        public DbSet<PersonelGorev> PersonelGorevleri { get; set; }
        public DbSet<PersonelSifre> PersonelSifreleri { get; set; }
        public DbSet<PersonelSosyalMedya> PersonelSosyalMedyalari { get; set; }
        public DbSet<SosyalMedyaLogo> SosyalMedyaLogolar { get; set; }


        public DbSet<TokensMailPassword> TokensMailPasswords { get; set; }
        public DbSet<TokensTable> TokensTables { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.RemoveRelationship();

            modelBuilder.AutoInclude();

            base.OnModelCreating(modelBuilder);
        }

    }
}
