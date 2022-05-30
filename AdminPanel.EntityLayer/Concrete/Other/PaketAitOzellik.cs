using AdminPanel.EntityLayer.Concrete.Base;

namespace AdminPanel.EntityLayer.Concrete.Other
{
    public class PaketAitOzellik : EntityBase
    {
        public Paket paket { get; set; }
        public PaketOzellik ozellik { get; set; }
    }
}
