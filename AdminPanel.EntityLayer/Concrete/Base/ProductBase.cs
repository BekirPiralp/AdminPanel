using AdminPanel.EntityLayer.Abctract;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdminPanel.EntityLayer.Concrete.Base
{
    public class ProductBase:IEntity
    {
        [Column("Id")]
        public int id { get; set; }
        DateTime CreatedOnUtc { get; set; }
        DateTime? LastModifiedOnUtc { get; set; }
        string ProcessMakingIP { get; set; }
        string CreatedBy { get; set; }
        string ModifiedBy { get; set; }
        byte[] Version { get; set; }
        public bool IsDeleted { get; set; }
    }
}
