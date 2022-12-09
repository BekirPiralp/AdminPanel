using AdminPanel.EntityLayer.Abctract;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdminPanel.EntityLayer.Concrete.Base
{
    public class ProductBase:IEntity
    {
        [Column("ProductId")]
        public int id { get; set; }
    }
}
