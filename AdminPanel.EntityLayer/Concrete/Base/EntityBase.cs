using AdminPanel.EntityLayer.Abctract;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdminPanel.EntityLayer.Concrete.Base
{
    public class EntityBase : IEntity
    {
        [Key]
        [Required]
        public int Id { get; set; }
        //[Column(TypeName ="bool")]
        public bool sil { get; set; } = false;
        [Required]
        public DateTime kayitZamani { get; set; }
        public DateTime? silmeZamani { get; set; }
        public DateTime? guncellemeZamani { get; set; }
    }

}
