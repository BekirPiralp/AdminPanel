using AdminPanel.EntityLayer.Concrete.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdminPanel.EntityLayer.Concrete.Other.LogoKismi
{
    [Table("SosyalMedyaLogolari")]
    public class SosyalMedyaLogo : EntityBase
    {
        /// <summary>
        /// sosyal medya şirketinin adı
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// sosyal medya logosu ayarlanmamış olabilir
        /// </summary>
        public string? logoURL { get; set; }
    }
}
