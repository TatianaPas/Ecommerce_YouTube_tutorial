using Ecommerce_YouTube_tutorial.Models;

namespace Ecommerce_YouTube_tutorial.Data
{
    public class AppDbInitialiser
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();
                context.Database.EnsureCreated();
                
            }
        }
    }
}
