using AdminPanel.EntityLayer.Concrete.Base;

namespace AdminPanel.EntityLayer.Concrete.Order
{
    public class PersonelSosyalMedya : EntityBase
    {
        public int personel { get; set; }
        public string sosyalMedyaURL { get; set; }
        public string sosyalMedyaLogo { get; set; }
    }
}
