using AdminPanel.EntityLayer.Concrete.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdminPanel.EntityLayer.Concrete.Other.ArabaKismi
{
    [Table(name:"ArabayaAitOzellikler")]
    public class ArabaAitOzellik : EntityBase
    {
        public virtual Araba araba { get; set; }
        public virtual ArabaOzellik ozellik { get; set; }
    }
}
