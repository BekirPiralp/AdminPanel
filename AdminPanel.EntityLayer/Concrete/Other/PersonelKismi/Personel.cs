using AdminPanel.EntityLayer.Concrete.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdminPanel.EntityLayer.Concrete.Other.PersonelKismi
{
    [Table("Personeller")]
    public class Personel : EntityBase
    {
        [MaxLength(11, ErrorMessage = "TC kimlik numarası 11 hanedir."), MinLength(11, ErrorMessage = "TC kimlik numarası 11 hanedir.")]
        public string tc { get; set; }
        public string ad { get; set; }
        public string soyad { get; set; }
        /// <summary>
        /// resmi yüklenmemiş olabilir
        /// </summary>
        public string? fotoURL { get; set; }
    }
}
