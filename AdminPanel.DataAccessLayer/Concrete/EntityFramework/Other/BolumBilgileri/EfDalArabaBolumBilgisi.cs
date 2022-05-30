﻿using AdminPanel.DataAccessLayer.Abstract.Other.Genel.BolumBilgileri;
using AdminPanel.DataAccessLayer.Concrete.EntityFramework.Base;
using AdminPanel.EntityLayer.Concrete.Other.BolumBilgileri;

namespace AdminPanel.DataAccessLayer.Concrete.EntityFramework.Other.BolumBilgileri
{
    public class EfDalArabaBolumBilgisi : EntityEfDal<ArabaBolumBilgisi, EfContext>, IDalArabaBolumBilgisi
    {
    }
}
