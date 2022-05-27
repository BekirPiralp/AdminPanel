using AdminPanel.EntityLayer.Concrete.Base;

namespace AdminPanel.EntityLayer.Concrete.Order
{
    public class Personel : EntityBase
    {
        public string ad { get; set; }
        public string soyad { get; set; }
        public string fotoURL { get; set; }
    }
}
