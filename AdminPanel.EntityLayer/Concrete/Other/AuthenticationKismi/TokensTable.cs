using AdminPanel.EntityLayer.Concrete.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdminPanel.EntityLayer.Concrete.Other.AuthenticationKismi
{
    [Table(name: "TokensTables")]
    public class TokensTable : EntityBase
    {
        public string? refreshToken {get;set;}
        public DateTime? refreshTokenDate {get;set;}
        public TokensMailPassword mailPassword { get; set; }
    } 
}
