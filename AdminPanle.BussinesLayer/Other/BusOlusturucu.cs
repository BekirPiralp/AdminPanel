using AdminPanel.DataAccessLayer.Other;
using AdminPanle.BusinessLayer.Abstract.Other.ArabaKismi;
using AdminPanle.BusinessLayer.Abstract.Other.BolumBilgileri;
using AdminPanle.BusinessLayer.Abstract.Other.FirmaKismi;
using AdminPanle.BusinessLayer.Abstract.Other.HakkindaKismi;
using AdminPanle.BusinessLayer.Abstract.Other.HizmetKismi;
using AdminPanle.BusinessLayer.Abstract.Other.IletisimKismi;
using AdminPanle.BusinessLayer.Abstract.Other.IpucuKismi;
using AdminPanle.BusinessLayer.Abstract.Other.LogoKismi;
using AdminPanle.BusinessLayer.Abstract.Other.MesajKismi;
using AdminPanle.BusinessLayer.Abstract.Other.MusteriKismi;
using AdminPanle.BusinessLayer.Abstract.Other.PaketKismi;
using AdminPanle.BusinessLayer.Abstract.Other.PersonelKismi;
using AdminPanle.BusinessLayer.Abstract.Other.ReferansKismi;
using AdminPanle.BusinessLayer.Concrete.Other.ArabaKismi;
using AdminPanle.BusinessLayer.Concrete.Other.BolumBilgileri;
using AdminPanle.BusinessLayer.Concrete.Other.FirmaKismi;
using AdminPanle.BusinessLayer.Concrete.Other.HakkindaKismi;
using AdminPanle.BusinessLayer.Concrete.Other.HizmetKismi;
using AdminPanle.BusinessLayer.Concrete.Other.IletisimKismi;
using AdminPanle.BusinessLayer.Concrete.Other.IpucuKismi;
using AdminPanle.BusinessLayer.Concrete.Other.LogoKismi;
using AdminPanle.BusinessLayer.Concrete.Other.MesajKismi;
using AdminPanle.BusinessLayer.Concrete.Other.MusteriKismi;
using AdminPanle.BusinessLayer.Concrete.Other.PaketKismi;
using AdminPanle.BusinessLayer.Concrete.Other.PersonelKismi;
using AdminPanle.BusinessLayer.Concrete.Other.ReferansKismi;

namespace AdminPanle.BusinessLayer.Other
{
    /// <summary>
    /// Business Layer Nesne oluşturucusu
    /// </summary>
    public class BusOlusturucu
    {
        private static BusOlusturucu _olusturucu;
        private static object _object = new Object();

        #region Araba kısmı
        public IBusAraba Araba { get; }
        public IBusArabaKasaTip ArabaKasaTip { get; }
        public IBusArabaMarka ArabaMarka { get; }
        public IBusArabaOzellik ArabaOzellik { get; }
        public IBusArabaTip ArabaTip { get; }
        public IBusArabaVitesTip ArabaVitesTip { get; }
        #endregion

        #region Bölüm Bilgileri
        public IBusArabaBolumBilgisi ArabaBolumBilgisi { get; }
        public IBusGaleriBolumBilgisi GaleriBolumBilgisi { get; }
        public IBusHakkindaBolumBilgisi HakkindaBolumBilgisi { get; }
        public IBusHizmetBolumBilgisi HizmetBolumBilgisi { get; }
        public IBusIletisimBolumBilgisi IletisimBolumBilgisi { get; }
        public IBusIpucuVeYaziBolumBilgisi IpucuVeYaziBolumBilgisi { get; }
        public IBusPaketBolumBilgisi PaketBolumBilgisi { get; }
        public IBusPersonelBolumBilgisi PersonelBolumBilgisi { get; }
        public IBusReferansBolumBilgisi ReferansBolumBilgisi { get; }
        #endregion

        #region Firma Kısmı
        public IBusBayi Bayi { get; }
        public IBusBayiYonetici BayiYonetici { get; }
        public IBusFirma Firma { get; }
        public IBusFirmaSahip FirmaSahip { get; }
        #endregion

        #region Hakkında Kısmı
        IBusHakkindaIcerik HakkindaIcerik { get; }
        IBusHakkindaReklam HakkindaReklam { get; }
        #endregion

        #region Hizmet Kısmı
        public IBusHizmet Hizmet { get; }
        public IBusHizmetAlt HizmetAlt { get; }
        public IBusHizmetAltOzellik HizmetAltOzellik { get; }
        #endregion

        #region İleteşim Kısmı
        public IBusIletisim Iletisim { get; }
        #endregion

        #region İpucu Kısmı
        public IBusIpucuVeYazi IpucuVeYazi { get; }
        #endregion

        #region Logo Kısmı
        public IBusSosyalMedyaLogo SosyalMedyaLogo { get; }
        #endregion

        #region Mesaj Kısmı
        public IBusMesaj Mesaj { get; }
        #endregion

        #region Müşteri Kısmı
        public IBusMusteri Musteri { get; }
        #endregion

        #region Paket Kısmı
        public IBusPaket Paket { get; }
        public IBusPaketAitOzellik PaketAitOzellik { get; }
        public IBusPaketOzellik PaketOzellik { get; }
        #endregion

        #region PersonelKismi
        public IBusPersonel Personel { get; }
        public IBusPersonelGorev PersonelGorev { get; }
        public IBusPersonelSifre PersonelSifre { get; }
        public IBusPersonelSosyalMedya PersonelSosyalMedya { get; }
        #endregion

        #region Referans kısmı
        public IBusReferans Referans { get; }
        #endregion
        private BusOlusturucu()
        {
            #region Araba kısmı
            Araba = new BusAraba(DalOlusturucu.Olustur().Araba);
            ArabaKasaTip = new BusArabaKasaTip(DalOlusturucu.Olustur().ArabaKasaTip);
            ArabaMarka = new BusArabaMarka(DalOlusturucu.Olustur().ArabaMarka);
            ArabaOzellik = new BusArabaOzellik(DalOlusturucu.Olustur().ArabaOzellik);
            ArabaTip = new BusArabaTip(DalOlusturucu.Olustur().ArabaTip);
            ArabaVitesTip = new BusArabaVitesTip(DalOlusturucu.Olustur().ArabaVitesTip);
            #endregion

            #region Bölüm Bilgileri
            ArabaBolumBilgisi = new BusArabaBolumBilgisi(DalOlusturucu.Olustur().ArabaBolumBilgisi);
            GaleriBolumBilgisi = new BusGaleriBolumBilgisi(DalOlusturucu.Olustur().GaleriBolumBilgisi);
            HakkindaBolumBilgisi = new BusHakkindaBolumBilgisi(DalOlusturucu.Olustur().HakkindaBolumBilgisi);
            HizmetBolumBilgisi = new BusHizmetBolumBilgisi(DalOlusturucu.Olustur().HizmetBolumBilgisi);
            IletisimBolumBilgisi = new BusIletisimBolumBilgisi(DalOlusturucu.Olustur().IletisimBolumBilgisi);
            IpucuVeYaziBolumBilgisi = new BusIpucuVeYaziBolumBilgisi(DalOlusturucu.Olustur().IpucuVeYaziBolumBilgisi);
            PaketBolumBilgisi = new BusPaketBolumBilgisi(DalOlusturucu.Olustur().PaketBolumBilgisi);
            PersonelBolumBilgisi = new BusPersonelBolumBilgisi(DalOlusturucu.Olustur().PersonelBolumBilgisi);
            ReferansBolumBilgisi = new BusReferansBolumBilgisi(DalOlusturucu.Olustur().ReferansBolumBilgisi);
            #endregion

            #region Firma Kısmı
            Bayi = new BusBayi(DalOlusturucu.Olustur().Bayi);
            BayiYonetici = new BusBayiYonetici(DalOlusturucu.Olustur().BayiYonetici);
            Firma = new BusFirma(DalOlusturucu.Olustur().Firma);
            FirmaSahip = new BusFirmaSahip(DalOlusturucu.Olustur().FirmaSahip);
            #endregion

            #region Hakkında Kısmı
            HakkindaIcerik = new BusHakkindaIcerik(DalOlusturucu.Olustur().HakkindaIcerik);
            HakkindaReklam = new BusHakkindaReklam(DalOlusturucu.Olustur().HakkindaReklam);
            #endregion

            #region Hizmet Kısmı
            Hizmet = new BusHizmet(DalOlusturucu.Olustur().Hizmet);
            HizmetAlt = new BusHizmetAlt(DalOlusturucu.Olustur().HizmetAlt);
            HizmetAltOzellik = new BusHizmetAltOzellik(DalOlusturucu.Olustur().HizmetAltOzellik);
            #endregion

            #region İleteşim Kısmı
            Iletisim = new BusIletisim(DalOlusturucu.Olustur().Iletisim);
            #endregion

            #region İpucu Kısmı
            IpucuVeYazi = new BusIpucuVeYazi(DalOlusturucu.Olustur().IpucuVeYazi);
            #endregion

            #region Logo Kısmı
            SosyalMedyaLogo = new BusSosyalMedyaLogo(DalOlusturucu.Olustur().SosyalMedyaLogo);
            #endregion

            #region Mesaj Kısmı
            Mesaj = new BusMesaj(DalOlusturucu.Olustur().Mesaj);
            #endregion

            #region Müşteri Kısmı
            Musteri = new BusMusteri(DalOlusturucu.Olustur().Musteri);
            #endregion

            #region Paket Kısmı
            Paket = new BusPaket(DalOlusturucu.Olustur().Paket);
            PaketAitOzellik = new BusPaketAitOzellik(DalOlusturucu.Olustur().PaketAitOzellik);
            PaketOzellik = new BusPaketOzellik(DalOlusturucu.Olustur().PaketOzellik);
            #endregion

            #region Personel Kısmı
            Personel = new BusPersonel(DalOlusturucu.Olustur().Personel);
            PersonelGorev = new BusPersonelGorev(DalOlusturucu.Olustur().PersonelGorev);
            PersonelSifre = new BusPersonelSifre(DalOlusturucu.Olustur().PersonelSifre);
            PersonelSosyalMedya = new BusPersonelSosyalMedya(DalOlusturucu.Olustur().PersonelSosyalMedya);
            #endregion

            #region Referans kısmı
            Referans = new BusReferans(DalOlusturucu.Olustur().Referans);
            #endregion
        }

        public static BusOlusturucu Olustur()
        {
            if (_olusturucu.isNull())
            {
                lock (_object)
                {
                    if (_olusturucu.isNull())
                    {
                        _olusturucu = new BusOlusturucu();
                    }
                }
            }
            return _olusturucu;
        }

    }

    internal static class geniset{
        internal static bool isNull(this BusOlusturucu olusturucu)
        {
            return olusturucu == null;
        }
    }
}
