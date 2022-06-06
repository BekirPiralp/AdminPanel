using AdminPanel.EntityLayer.Concrete.Base;
using AdminPanel.EntityLayer.Concrete.Other.FirmaKismi;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdminPanel.EntityLayer.Concrete.Other.MusteriKismi
{
    [Serializable]
    [Table("Musteriler")]
    public class Musteri : EntityBase
    {
        public virtual Firma firma { get; set; }
        [MaxLength(11, ErrorMessage = "TC kimlik numarası 11 hanedir."), MinLength(11, ErrorMessage = "TC kimlik numarası 11 hanedir.")]
        public string tc { get; set; }
        public string ad { get; set; }
        public string soyad { get; set; }
    }
}
