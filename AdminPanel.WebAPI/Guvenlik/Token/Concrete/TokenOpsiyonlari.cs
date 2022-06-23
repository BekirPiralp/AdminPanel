using AdminPanel.WebAPI.Guvenlik.Token.Abstract;

namespace AdminPanel.WebAPI.Guvenlik.Token.Concrete
{
    public class TokenOpsiyonlari : ITokenOpsiyonlari
    {
        /// <summary>
        /// Audience
        /// </summary>
        public string Dinleyici { get; set; }
        /// <summary>
        /// Issuer
        /// </summary>
        public string Yayinci { get; set; }

        public int AccessTokenSonKulanim { get; set; }
        public int RefreshTokenSonKullanim { get; set; }
        public int GecerlilikBaslamasi { get; set; }

        public string GuvenlikAnahtari { get; set; }
        public int GecikmeSuresi { get; set; } = 0;
    }
}
