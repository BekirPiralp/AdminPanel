using AdminPanel.EntityLayer.Abctract;

namespace AdminPanel.EntityLayer.Concrete.Base
{
    public class EntityBase : IEntity
    {
        public int id { get; set; }
        public bool sil { get; set; } = false;
    }

}
