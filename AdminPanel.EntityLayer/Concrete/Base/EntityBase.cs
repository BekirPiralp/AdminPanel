using AdminPanel.EntityLayer.Abctract;
using System.ComponentModel.DataAnnotations;

namespace AdminPanel.EntityLayer.Concrete.Base
{
    public class EntityBase : IEntity
    {
        [Key]
        public int id { get; set; }
        public bool sil { get; set; } = false;
    }

}
