using AdminPanel.EntityLayer.Concrete.Base;
using AdminPanel.EntityLayer.Concrete.Other.PersonelKismi;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdminPanel.EntityLayer.Concrete.Other.FirmaKismi
{
    [Serializable]
    [Table("FirmaSahipleri")]
    public class FirmaSahip : EntityBase
    {
        public virtual Firma firma { get; set; }
        /// <summary>
        /// Firma sahibi değişe bilier veya firma sisteme yeni kayıt yapılıyor olabilir
        /// </summary>
        public virtual Personel? personel { get; set; }
    }
}
