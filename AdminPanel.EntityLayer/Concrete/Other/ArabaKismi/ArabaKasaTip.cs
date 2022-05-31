﻿using AdminPanel.EntityLayer.Concrete.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdminPanel.EntityLayer.Concrete.Other.ArabaKismi
{
    [Table("ArabaKasaTipleri")]
    public class ArabaKasaTip : EntityBase
    {
        public string isim { get; set; }
    }
}