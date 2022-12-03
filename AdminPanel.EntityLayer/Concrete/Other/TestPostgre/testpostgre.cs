using AdminPanel.EntityLayer.Abctract;

namespace AdminPanel.EntityLayer.Concrete.Other.TestPostgre
{
    public class testpostgre : IEntity
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
}
