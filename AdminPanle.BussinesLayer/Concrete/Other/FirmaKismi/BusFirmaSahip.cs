using AdminPanel.DataAccessLayer.Abstract.Base;
using AdminPanel.DataAccessLayer.Abstract.Other.Genel.FirmaKismi;
using AdminPanel.EntityLayer.Concrete.Other.FirmaKismi;
using AdminPanle.BusinessLayer.Abstract.Other.FirmaKismi;
using AdminPanle.BusinessLayer.Concrete.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminPanle.BusinessLayer.Concrete.Other.FirmaKismi
{
    public class BusFirmaSahip : EntityBusBase<FirmaSahip>, IBusFirmaSahip
    {
        public BusFirmaSahip(IDalFirmaSahip entityDalBase) : base(entityDalBase)
        {
        }
    }
}
