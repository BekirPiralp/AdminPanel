using AdminPanel.EntityLayer.Abctract;
using System.ComponentModel.DataAnnotations;

namespace AdminPanel.EntityLayer.Concrete.Base
{
    public class EntityBase : IEntity
    {
        [Key]
        public int id { get; set; }
        public bool sil { get; set; } = false;
        public DateTime kayitZamani { get; set; }
        public DateTime silmeZamani { get; set; }
        public DateTime guncellemeZamani { get; set; }
    }

}
