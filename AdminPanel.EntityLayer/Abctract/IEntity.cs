using System.ComponentModel.DataAnnotations;

namespace AdminPanel.EntityLayer.Abctract
{
    public interface IEntity
    {
        [Key]
        int id { get; set; }
        bool sil { get; set; }
        DateTime kayitZamani { get; set; }
        DateTime silmeZamani { get; set; }
        DateTime guncellemeZamani { get; set; }
    }
}
