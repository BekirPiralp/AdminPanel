using AdminPanel.DataAccessLayer.Concrete.EntityFramework;

namespace AdminPanel.WebAPI.Extesion
{
    public static class WepApplicationExtension
    {
        public static void VeriTabaniniKaydet(this WebApplication app)
        {
            //using (var scope = app.Services.CreateScope())
            //{
               
            //    var services = scope.ServiceProvider;

            //    var baglam = services.GetRequiredService<EfContext>();
            //    baglam.Database.EnsureCreated();
            //    //var response = baglam.Database.EnsureCreatedAsync().Result;

            //    //Console.WriteLine(response);
            //}
        }
    }
}
