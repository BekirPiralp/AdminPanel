using AdminPanel.DataAccessLayer.Abstract.Other.Genel.YBS_Asis;
using AdminPanel.EntityLayer.Concrete.Other.Ybs_Filo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdminPanel.DataAccessLayer.Concrete.EntityFramework.Base;
using AdminPanel.DataAccessLayer.Concrete.EntityFramework.Base.Oracle;

namespace AdminPanel.DataAccessLayer.Concrete.EntityFramework.Other.YBS_Asis
{
    public class GetTempDAL : EntityEfDalOracle<TEMP_SOSYALYARDIM3, EFContextOracle>, IGetTempDAL
    {

        
    }
}
