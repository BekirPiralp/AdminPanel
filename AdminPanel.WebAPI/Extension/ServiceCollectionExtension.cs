using AdminPanel.DataAccessLayer.Concrete.EntityFramework;
using AdminPanel.WebAPI.Guvenlik.Other;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using MIMT = Microsoft.IdentityModel.Tokens;

namespace AdminPanel.WebAPI.Extension
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddConnectionString(this IServiceCollection service, WebApplicationBuilder builder)
        {
            "".setConnectionString(builder.Configuration.GetConnectionString("Varsayilan"));

            service.AddDbContext<EfContext>(op => op.UseSqlServer("".getConnectionString()));
            return service;
        }

        public static void AddCrosAyari(this IServiceCollection services)
        {
            /** Cros ayarı**/
            services.AddCors(opt =>
            {
                opt.AddDefaultPolicy(builder => { builder.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod(); }); // TODO Allovcredential ? 
            });
        }

        public static void AddJwt(this IServiceCollection services)
        {
            var imzalayici = GuvenlikOlusturucu.Olustur().Imzalayici;
            var tokenOption = GuvenlikOlusturucu.Olustur().TokenOpsiyonlari;

            var authenticationBuilder = services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme);

            authenticationBuilder.AddJwtBearer(JwtBearerOptions =>
            {
                JwtBearerOptions.TokenValidationParameters = new MIMT.TokenValidationParameters()
                {
                    ValidateAudience = true,
                    ValidateIssuer = true,
                    ValidateLifetime = true,
                    ValidateIssuerSigningKey = false,
                    ValidIssuer = tokenOption.Yayinci,
                    ValidAudience = tokenOption.Dinleyici,
                    IssuerSigningKey = imzalayici.GetSecurityKey(tokenOption.GuvenlikAnahtari),
                    ClockSkew = new TimeSpan(0, tokenOption.GecikmeSuresi, 0)
                };

            });

           

        }

    }
}
