using AdminPanel.EntityLayer.Abctract;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdminPanel.EntityLayer.Concrete.Other.TestPostgre
{
    
    public class testpostgre : IEntity
    {
        [Column("id")]
        public int ID { get; set; }
        [Column("name")]
        public string Name { get; set; }
    }
}
