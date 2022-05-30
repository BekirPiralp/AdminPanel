using AdminPanel.EntityLayer.Concrete.Base;

namespace AdminPanel.EntityLayer.Concrete.Other
{
    public class ArabaOzellik : EntityBase
    {
        public Araba araba { get; set; }
        public string isim { get; set; }
    }
}
