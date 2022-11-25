using System.ComponentModel.DataAnnotations;

namespace AdminPanel.EntityLayer.Abctract
{
    public interface IEntity
    {
        [Key]
        int ID { get; set; }
        ////[Column(TypeName = "boolean")]
        //bool sil { get; set; }
        //[Required]
        //DateTime? kayitZamani { get; set; }
        //DateTime? silmeZamani { get; set; }
        //DateTime? guncellemeZamani { get; set; }
    }
}
