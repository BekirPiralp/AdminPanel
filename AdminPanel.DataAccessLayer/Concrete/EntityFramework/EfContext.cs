using AdminPanel.EntityLayer.Concrete.Other;
using Microsoft.EntityFrameworkCore;

namespace AdminPanel.DataAccessLayer.Concrete.EntityFramework
{
    public class EfContext : DbContext
    {
        DbSet<Araba> Arabas { get; set; }
        DbSet<ArabaBolumBilgisi> ArabaBolumBilgisis { get; set; }
        DbSet<ArabaKasaTip> ArabaKasaTips { get; set; }
        DbSet<ArabaMarka> ArabaMarkas { get; set; }
        DbSet<ArabaOzellik> ArabaOzelliks { get; set; }
        DbSet<ArabaTip> ArabaTips { get; set; }
        DbSet<ArabaVitesTip> ArabaVitesTips { get; set; }
        
        DbSet<Bayi> Bayis { get; set; }
        DbSet<BayiYonetici> BayiYoneticis { get; set; }
        DbSet<Firma> Firmas { get; set; }
        DbSet<FirmaSahip> FirmaSahips { get; set; }

        DbSet<GaleriBolumBilgisi> GaleriBolumBilgisis { get; set; }
        DbSet<HakkindaBolumBilgisi> HakkindaBolumBilgisis { get; set; }
        DbSet<HakkindaIcerik> HakkindaIceriks { get; set; }
        DbSet<HakkindaReklam> HakkindaReklams { get; set; }

        DbSet<Hizmet> Hizmets { get; set; }
        DbSet<HizmetAlt> HizmetAlts { get; set; }
        DbSet<HizmetAltOzellik> HizmetAltOzelliks { get; set; }
        DbSet<HizmetBolumBilgisi> HizmetBolumBilgisis { get; set; }

        DbSet<Iletisim> Iletisims { get; set; }
        DbSet<IletisimBolumBilgisi> IletisimBolumBilgisis { get; set; }

        DbSet<IpucuVeYazi> IpucuVeYazis { get; set; }
        DbSet<IpucuVeYaziBolumBilgisi> IpucuVeYaziBolumBilgisis { get; set; }

        DbSet<Mesaj> Mesajs { get; set; }
        DbSet<Musteri> Musteris { get; set; }

        DbSet<Paket> Pakets { get; set; }
        DbSet<PaketAitOzellik> PaketAitOzelliks { get; set; }
        DbSet<PaketBolumBilgisi> PaketBolumBilgisis { get; set; }
        DbSet<PaketOzellik> PaketOzelliks { get; set; }

        DbSet<Personel> Personels { get; set; }
        DbSet<PersonelBolumBilgisi> PersonelBolumBilgisis { get; set; }
        DbSet<PersonelGorev> PersonelGorevs { get; set; }
        DbSet<PersonelSifre> PersonelSifres { get; set; }
        DbSet<PersonelSosyalMedya> PersonelSosyalMedyas { get; set; }
        DbSet<SosyalMedyaLogo> SosyalMedyaLogos { get; set; }
    }
}
