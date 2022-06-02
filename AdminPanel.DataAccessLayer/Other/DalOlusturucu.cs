using AdminPanel.DataAccessLayer.Abstract.Other.Genel.ArabaKismi;
using AdminPanel.DataAccessLayer.Abstract.Other.Genel.BolumBilgileri;
using AdminPanel.DataAccessLayer.Concrete.EntityFramework.Other.ArabaKismi;
using AdminPanel.DataAccessLayer.Concrete.EntityFramework.Other.BolumBilgileri;

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

        #region BolumBilgileri
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

            #region BolumBilgileri
            ArabaBolumBilgisi = new EfDalArabaBolumBilgisi();
            GaleriBolumBilgisi = new EfDalGaleriBolumBilgisi();
            HakkindaBolumBilgisi = new EfDalHakkindaBolumBilgisi();
            HizmetBolumBilgisi = new EfDalHizmetBolumBilgisi();
            IletisimBolumBilgisi = new EfDalIletisimBolumBilgisi();
            IpucuVeYaziBolumBilgisi = new EfDalIpucuVeYaziBolumBilgisi ();
            PaketBolumBilgisi = new EfDalPaketBolumBilgisi();
            PersonelBolumBilgisi = new EfDalPersonelBolumBilgisi();
            ReferansBolumBilgisi = new EfDalReferansBolumBilgisi();
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
