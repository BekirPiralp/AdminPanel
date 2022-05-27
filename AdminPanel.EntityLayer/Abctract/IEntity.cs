using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminPanel.EntityLayer.Abctract
{
    public interface IEntity
    {
        int id { get; set; }
        bool sil { get; set; }
    }
}
