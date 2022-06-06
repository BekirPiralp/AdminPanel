using AdminPanel.EntityLayer.Concrete.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdminPanel.EntityLayer.Concrete.Other.HizmetKismi
{
    [Serializable]
    [Table("HizmetAltlar")]
    public class HizmetAlt : EntityBase
    {
        public virtual Hizmet hizmet { get; set; }
        public string isim { get; set; }
    }
}
