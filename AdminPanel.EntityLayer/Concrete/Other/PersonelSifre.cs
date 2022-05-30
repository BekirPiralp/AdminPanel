using AdminPanel.EntityLayer.Concrete.Base;

namespace AdminPanel.EntityLayer.Concrete.Other
{
    public class PersonelSifre : EntityBase
    {
        public Personel personel { get; set; }
        public string sifre { get; set; }
    }
}
