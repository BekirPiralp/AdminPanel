using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdminPanel.EntityLayer.Abctract
{
    public interface IEntity
    {
        [Key]
        int Id { get; set; }
        //[Column(TypeName = "boolean")]
        bool sil { get; set; }
        [Required]
        DateTime kayitZamani { get; set; }
        DateTime? silmeZamani { get; set; }
        DateTime? guncellemeZamani { get; set; }
    }
}
