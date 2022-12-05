using AdminPanel.EntityLayer.Abctract;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdminPanel.EntityLayer.Concrete.Other.TestPostgre
{
    public class testpostgre : IEntity
    {
        [Column("id")]
        public int ID { get; set; }
        public string Name { get; set; }
    }
}
