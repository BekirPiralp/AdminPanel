using AdminPanel.EntityLayer.Abctract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminPanel.EntityLayer.Concrete.Base
{
    public class YbsFiloBase : IEntity
    {
        public int ID { get; set; }
        //public bool sil { get; set; }
        //public DateTime kayitZamani { get; set; }
        //public DateTime? silmeZamani { get; set; }
        //public DateTime? guncellemeZamani { get; set; }
    }
}
