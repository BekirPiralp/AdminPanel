﻿using AdminPanel.EntityLayer.Concrete.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdminPanel.EntityLayer.Concrete.Other.AuthenticationKismi
{
    [Table(name: "TokensTables")]
    public class TokensTable : EntityBase
    {
        public string? refreshToken {get;set;}
        public DateTime? refreshTokenDate {get;set;}
        public TokensMailPassword mailPassword { get; set; }
        /// <summary>
        /// gecerli ise true değil ise false süreden 
        /// bağımsız yapılan geçerlilik için geçerli
        /// </summary>
        public bool gecerlilikDurumu { get; set;}=true;
    } 
}
