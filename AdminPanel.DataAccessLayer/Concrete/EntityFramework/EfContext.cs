using AdminPanel.EntityLayer.Concrete.Other;
using Microsoft.EntityFrameworkCore;

namespace AdminPanel.DataAccessLayer.Concrete.EntityFramework
{
    public class EfContext : DbContext
    {
        DbSet<Araba> Arabalar { get; set; }
        DbSet<ArabaBolumBilgisi> ArabaBolumBilgileri { get; set; }
        DbSet<ArabaKasaTip> ArabaKasaTipleri { get; set; }
        DbSet<ArabaMarka> ArabaMarkalari { get; set; }
        DbSet<ArabaOzellik> ArabaOzellikleri { get; set; }
        DbSet<ArabaTip> ArabaTipleri { get; set; }
        DbSet<ArabaVitesTip> ArabaVitesTipleri { get; set; }
        
        DbSet<Bayi> Bayiler { get; set; }
        DbSet<BayiYonetici> BayiYoneticileri { get; set; }
        DbSet<Firma> Firmalar { get; set; }
        DbSet<FirmaSahip> FirmaSahipleri { get; set; }

        DbSet<GaleriBolumBilgisi> GaleriBolumBilgileri { get; set; }
        DbSet<HakkindaBolumBilgisi> HakkindaBolumBilgileri { get; set; }
        DbSet<HakkindaIcerik> HakkindaIcerikler { get; set; }
        DbSet<HakkindaReklam> HakkindaReklamlar { get; set; }

        DbSet<Hizmet> Hizmetler { get; set; }
        DbSet<HizmetAlt> HizmetAltlar { get; set; }
        DbSet<HizmetAltOzellik> HizmetAltOzellikler { get; set; }
        DbSet<HizmetBolumBilgisi> HizmetBolumBilgileri { get; set; }

        DbSet<Iletisim> Iletisimler { get; set; }
        DbSet<IletisimBolumBilgisi> IletisimBolumBilgileri { get; set; }

        DbSet<IpucuVeYazi> IpucuVeYazilar { get; set; }
        DbSet<IpucuVeYaziBolumBilgisi> IpucuVeYaziBolumBilgileri { get; set; }

        DbSet<Mesaj> Mesajlar { get; set; }
        DbSet<Musteri> Musteriler { get; set; }

        DbSet<Paket> Paketler { get; set; }
        DbSet<PaketAitOzellik> PaketAitOzellikleri { get; set; }
        DbSet<PaketBolumBilgisi> PaketBolumBilgileri { get; set; }
        DbSet<PaketOzellik> PaketOzellikleri { get; set; }

        DbSet<Personel> Personeller { get; set; }
        DbSet<PersonelBolumBilgisi> PersonelBolumBilgileri { get; set; }
        DbSet<PersonelGorev> PersonelGorevleri { get; set; }
        DbSet<PersonelSifre> PersonelSifreleri { get; set; }
        DbSet<PersonelSosyalMedya> PersonelSosyalMedyalari { get; set; }
        DbSet<SosyalMedyaLogo> SosyalMedyaLogolar { get; set; }
    }
}
