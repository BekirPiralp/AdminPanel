using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.OpenApi.Models;

namespace AdminPanel.WebAPI.Extension
{
    internal static class SwagerExtensions
    {
        internal static void AddSwagerAuthorization(this IServiceCollection services)
        {
            services.AddSwaggerGen(opt =>
            {
                opt.SwaggerDoc("v1", new OpenApiInfo()
                {
                    Title = "Admin paneli API",
                    Version = "v01",
                    //Description = "Admin panelinin api kısmıdır ve bir araba kiralam şirketine hizmet edecektir."
                });

                opt.AddSecurityDefinition("Güvenlik Kısmı",
                    new OpenApiSecurityScheme(){
                        In = ParameterLocation.Header,
                        Description = "Lütfen tokenı giriniz",
                        Name = "Authorize",
                        Type = SecuritySchemeType.Http,
                        BearerFormat = "JWT",
                        Scheme = "Bearer"//JwtBearerDefaults.AuthenticationScheme
                    });

                var oASS = new OpenApiSecurityScheme()
                {
                    Reference = new OpenApiReference
                    {
                        Id = "Bearer",//JwtBearerDefaults.AuthenticationScheme,
                        Type = ReferenceType.SecurityScheme
                    }
                };

                var value = new List<string>();

                
                opt.AddSecurityRequirement(new OpenApiSecurityRequirement(){{
                        oASS,value
                    }}
                );
            });
        }
    }
}
