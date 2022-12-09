using AdminPanel.EntityLayer.Abctract;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdminPanel.EntityLayer.Concrete.Other.TestPostgre
{
    
    public class testpostgre : IEntity
    {
        [Column("id")]
        public int id { get; set; }
        [Column("name")]
        public string name { get; set; }

        [Column("veriint")]
        public int veriInt { get; set; }

        [Column("veribool")]
        public bool veriBool { get; set; }
    }
}
