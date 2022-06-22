using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.OpenApi.Models;

namespace AdminPanel.WebAPI.Extension
{
    internal static class SwagerExtensions
    {
        internal static void AddSwagerAuthorization(this IServiceCollection services)
        {
            services.AddSwaggerGen(
                stpAction =>
                {
                    stpAction.SwaggerDoc("v1", new OpenApiInfo { 
                        Title = "Admin paneli API",
                        Version = "v001",
                        Description = "Admin panelinin api kısmıdır ve bir araba kiralam şirketine hizmet edecektir."
                    });

                    stpAction.AddSecurityDefinition("Güvenlik Kısmı",
                        new OpenApiSecurityScheme
                        {
                            In = ParameterLocation.Header,
                            Description = "Lütfen tokenı giriniz",
                            Name = "Authorize",
                            Type = SecuritySchemeType.Http,
                            BearerFormat = "jwt",
                            Scheme = JwtBearerDefaults.AuthenticationScheme
                        }
                        );

                    var oASS = new OpenApiSecurityScheme
                    {
                        Reference = new OpenApiReference
                        {
                            Id = JwtBearerDefaults.AuthenticationScheme,
                            Type = ReferenceType.SecurityScheme
                        }
                    };

                    var value = new List<string>();

                    //Dictionary<OpenApiSecurityScheme,IList<string>> val =  
                    //new Dictionary<OpenApiSecurityScheme, IList<string>>(){ {oASS,value } };
                    //val.Add(oASS, value);

                    stpAction.AddSecurityRequirement(new OpenApiSecurityRequirement{{
                            oASS,value 
                        }}
                    ) ;
                });
        }
    }
}
