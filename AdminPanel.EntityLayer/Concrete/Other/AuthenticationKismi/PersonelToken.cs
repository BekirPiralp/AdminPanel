using AdminPanel.EntityLayer.Concrete.Base;

namespace AdminPanel.EntityLayer.Concrete.Other.AuthenticationKismi
{
    public class PersonelToken : EntityBase
    {
        public string? RefreshToken {get;set;}
        public DateTime? RefreshTokenDate {get;set;}
    }
}
