﻿using AdminPanel.DataAccessLayer.Abstract.Other.Genel.TestPostgre;
using AdminPanel.DataAccessLayer.Concrete.EntityFramework.Base.Postgre;
using AdminPanel.EntityLayer.Concrete.Other.TestPostgre;

namespace AdminPanel.DataAccessLayer.Concrete.EntityFramework.Other.TestPostgre
{
    public class EfDalTestPostgre : EntityEfDalPostgre<testpostgre,EfContextPostgre>, ITestPostgreDal
    {
    }
}
