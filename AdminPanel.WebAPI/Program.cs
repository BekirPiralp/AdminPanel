using AdminPanel.WebAPI.Extension;
using AdminPanel.WebAPI.Guvenlik.Other;
using Microsoft.AspNetCore.Authentication.JwtBearer;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddConnectionString(builder);
builder.Services.AddCrosAyari();
//builder.Services.AddJwt();

builder.Services.AddAuthentication(defaultScheme: JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(JwtBearerDefaults.AuthenticationScheme,opt =>
{
    opt.TokenValidationParameters = new Microsoft.IdentityModel.Tokens.TokenValidationParameters()
    {
        ValidateAudience = true,
        ValidateIssuer = true,
        ValidateLifetime = true,
        ValidateIssuerSigningKey = true,
        ValidIssuer = GuvenlikOlusturucu.Olustur().TokenOpsiyonlari.Yayinci,
        ValidAudience = GuvenlikOlusturucu.Olustur().TokenOpsiyonlari.Dinleyici,
        IssuerSigningKey = GuvenlikOlusturucu.Olustur().Imzalayici.GetSecurityKey(GuvenlikOlusturucu.Olustur().TokenOpsiyonlari.GuvenlikAnahtari),
    };
});



builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen();
builder.Services.AddSwagerAuthorization();

var app = builder.Build();

app.VeriTabaniniKaydet();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


app.UseCors();

app.UseHttpsRedirection();

//app.UseRouting();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();
