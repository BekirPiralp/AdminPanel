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
                    stpAction.SwaggerDoc("SwagerDokumani", new OpenApiInfo { 
                        Title = "Admin paneli API",
                        Version = "v001",
                        Description = "Admin panelinin api kısmı dır ve bir araba kiralam şirketine hizmet edecektir."
                    });

                    stpAction.AddSecurityDefinition("GuvenlikTanimlamasi",
                        new OpenApiSecurityScheme
                        {
                            In = ParameterLocation.Header,
                            Description = "Lütfen tokenı giriniz",
                            Name = "GirisKismi",
                            Type = SecuritySchemeType.ApiKey,
                            BearerFormat = "JWT",
                            Scheme = "Bearer"
                        }
                        );

                    var oASS = new OpenApiSecurityScheme
                    {
                        Reference = new OpenApiReference
                        {
                            Id = "Bearer",
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
