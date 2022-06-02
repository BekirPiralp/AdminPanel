using AdminPanel.DataAccessLayer.Abstract.Other.Genel.ArabaKismi;
using AdminPanel.DataAccessLayer.Abstract.Other.Genel.BolumBilgileri;
using AdminPanel.DataAccessLayer.Abstract.Other.Genel.FirmaKismi;
using AdminPanel.DataAccessLayer.Abstract.Other.Genel.HakkindaKismi;
using AdminPanel.DataAccessLayer.Abstract.Other.Genel.HizmetKismi;
using AdminPanel.DataAccessLayer.Abstract.Other.Genel.IletisimKsimi;
using AdminPanel.DataAccessLayer.Abstract.Other.Genel.IpucuKismi;
using AdminPanel.DataAccessLayer.Abstract.Other.Genel.LogoKismi;
using AdminPanel.DataAccessLayer.Abstract.Other.Genel.MesajKismi;
using AdminPanel.DataAccessLayer.Abstract.Other.Genel.MusteriKismi;
using AdminPanel.DataAccessLayer.Abstract.Other.Genel.PaketKismi;
using AdminPanel.DataAccessLayer.Concrete.EntityFramework.Other.ArabaKismi;
using AdminPanel.DataAccessLayer.Concrete.EntityFramework.Other.BolumBilgileri;
using AdminPanel.DataAccessLayer.Concrete.EntityFramework.Other.FirmaKismi;
using AdminPanel.DataAccessLayer.Concrete.EntityFramework.Other.HakkindaKismi;
using AdminPanel.DataAccessLayer.Concrete.EntityFramework.Other.HizmetKismi;
using AdminPanel.DataAccessLayer.Concrete.EntityFramework.Other.IletisimKismi;
using AdminPanel.DataAccessLayer.Concrete.EntityFramework.Other.IpucuKismi;
using AdminPanel.DataAccessLayer.Concrete.EntityFramework.Other.LogoKismi;
using AdminPanel.DataAccessLayer.Concrete.EntityFramework.Other.MesajKismi;
using AdminPanel.DataAccessLayer.Concrete.EntityFramework.Other.MusteriKismi;
using AdminPanel.DataAccessLayer.Concrete.EntityFramework.Other.PaketKismi;

namespace AdminPanel.DataAccessLayer.Other
{
    /// <summary>
    /// Data Access Layer Nesne Olusturucusu
    /// </summary>
    public class DalOlusturucu
    {
        private static DalOlusturucu? _nesneOlusturucu;
        private static readonly Object kilit = new Object();

        #region Araba kısmı
        public IDalAraba Araba { get; }
        public IDalArabaKasaTip ArabaKasaTip { get; }
        public IDalArabaMarka ArabaMarka { get; }
        public IDalArabaOzellik ArabaOzellik { get; }
        public IDalArabaTip ArabaTip { get; }
        public IDalArabaVitesTip ArabaVitesTip { get; }
        #endregion

        #region Bölüm Bilgileri
        public IDalArabaBolumBilgisi ArabaBolumBilgisi { get; }
        public IDalGaleriBolumBilgisi GaleriBolumBilgisi { get; }
        public IDalHakkindaBolumBilgisi HakkindaBolumBilgisi { get; }
        public IDalHizmetBolumBilgisi HizmetBolumBilgisi { get; }
        public IDalIletisimBolumBilgisi IletisimBolumBilgisi { get; }
        public IDalIpucuVeYaziBolumBilgisi IpucuVeYaziBolumBilgisi { get; }
        public IDalPaketBolumBilgisi PaketBolumBilgisi { get; }
        public IDalPersonelBolumBilgisi PersonelBolumBilgisi { get; }
        public IDalReferansBolumBilgisi ReferansBolumBilgisi { get; }
        #endregion

        #region Firma Kısmı
        public IDalBayi Bayi { get; }
        public IDalBayiYonetici BayiYonetici { get; }
        public IDalFirma Firma { get; }
        public IDalFirmaSahip FirmaSahip { get; }
        #endregion

        #region Hakkında Kısmı
        IDalHakkindaIcerik HakkindaIcerik { get; }
        IDalHakkindaReklam HakkindaReklam { get; }
        #endregion

        #region Hizmet Kısmı
        public IDalHizmet Hizmet { get; }
        public IDalHizmetAlt HizmetAlt { get; }
        public IDalHizmetAltOzellik HizmetAltOzellik { get; }
        #endregion

        #region İleteşim Kısmı
        public IDalIletisim Iletisim { get; }
        #endregion

        #region İpucu Kısmı
        public IDalIpucuVeYazi IpucuVeYazi { get; }
        #endregion

        #region Logo Kısmı
        public IDalSosyalMedyaLogo SosyalMedyaLogo { get; }
        #endregion

        #region Mesaj Kısmı
        public IDalMesaj Mesaj { get; }
        #endregion

        #region Müşteri Kısmı
        public IDalMusteri Musteri { get; }
        #endregion

        #region Paket Kısmı
        public IDalPaket Paket { get; }
        public IDalPaketAitOzellik PaketAitOzellik { get; }
        public IDalPaketOzellik PaketOzellik { get; }
        #endregion

        private DalOlusturucu()
        {
            #region Araba kısmı
            Araba = new EfDalAraba();
            ArabaKasaTip = new EfDalArabaKasaTip();
            ArabaMarka = new EfDalArabaMarka();
            ArabaOzellik = new EfDalArabaOzellik();
            ArabaTip = new EfDalArabaTip();
            ArabaVitesTip = new EfDalArabaVitesTip();
            #endregion

            #region Bölüm Bilgileri
            ArabaBolumBilgisi = new EfDalArabaBolumBilgisi();
            GaleriBolumBilgisi = new EfDalGaleriBolumBilgisi();
            HakkindaBolumBilgisi = new EfDalHakkindaBolumBilgisi();
            HizmetBolumBilgisi = new EfDalHizmetBolumBilgisi();
            IletisimBolumBilgisi = new EfDalIletisimBolumBilgisi();
            IpucuVeYaziBolumBilgisi = new EfDalIpucuVeYaziBolumBilgisi();
            PaketBolumBilgisi = new EfDalPaketBolumBilgisi();
            PersonelBolumBilgisi = new EfDalPersonelBolumBilgisi();
            ReferansBolumBilgisi = new EfDalReferansBolumBilgisi();
            #endregion

            #region Firma Kısmı
            Bayi = new EfDalBayi();
            BayiYonetici = new EfDalBayiYonetici();
            Firma = new EfDalFirma();
            FirmaSahip = new EfDalFirmaSahip();
            #endregion

            #region Hakkında Kısmı
            HakkindaIcerik = new EfDalHakkindaIcerik();
            HakkindaReklam = new EfDalHakkindaReklam();
            #endregion

            #region Hizmet Kısmı
            Hizmet = new EfDalHizmet();
            HizmetAlt = new EfDalHizmetAlt();
            HizmetAltOzellik = new EfDalHizmetAltOzellik();
            #endregion

            #region İleteşim Kısmı
            Iletisim = new EfDalIletisim();
            #endregion

            #region İpucu Kısmı
            IpucuVeYazi = new EfDalIpucuVeYazi();
            #endregion

            #region Logo Kısmı
            SosyalMedyaLogo = new EfDalSosyalMedyaLogo();
            #endregion

            #region Mesaj Kısmı
            Mesaj = new EfDalMesaj();
            #endregion

            #region Müşteri Kısmı
            Musteri = new EfDalMusteri();
            #endregion

            #region Paket Kısmı
            Paket = new EfDalPaket();
            PaketAitOzellik = new EfDalPaketAitOzellik();
            PaketOzellik = new EfDalPaketOzellik();
            #endregion
        }

        private static DalOlusturucu Olustur()
        {
            if (_nesneOlusturucu.isNull())
            {
                lock (kilit)
                {
                    if (_nesneOlusturucu.isNull())
                    {
                        _nesneOlusturucu = new DalOlusturucu();
                    }
                }
            }
            return _nesneOlusturucu;
        }
    }

    internal static class genislet
    {
        internal static bool isNull(this DalOlusturucu olusturucu)
        {
            return olusturucu == null;
        }
    }
}
