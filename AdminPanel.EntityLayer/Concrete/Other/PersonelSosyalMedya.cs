using AdminPanel.EntityLayer.Concrete.Base;

namespace AdminPanel.EntityLayer.Concrete.Other
{
    public class PersonelSosyalMedya : EntityBase
    {
        public int personel { get; set; }
        public string sosyalMedyaURL { get; set; }
        public string sosyalMedyaLogo { get; set; }
    }
}
