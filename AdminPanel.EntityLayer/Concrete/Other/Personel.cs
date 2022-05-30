using AdminPanel.EntityLayer.Concrete.Base;
using System.ComponentModel.DataAnnotations;

namespace AdminPanel.EntityLayer.Concrete.Other
{
    public class Personel : EntityBase
    {
        [MaxLength(11, ErrorMessage = "TC kimlik numarası 11 hanedir."), MinLength(11, ErrorMessage = "TC kimlik numarası 11 hanedir.")]
        public string tc { get; set; }
        public string ad { get; set; }
        public string soyad { get; set; }
        public string fotoURL { get; set; }
    }
}
