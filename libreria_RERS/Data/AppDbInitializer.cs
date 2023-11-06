using libreria_RERS.Data.Models;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Builder;
using System.Linq;
using System;
using System.Threading;

namespace libreria_RERS.Data
{
    public class AppDbInitialer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();
                if (!context.Books.Any())
                {
                    context.Books.AddRange(new Books()
                    {
                        Titulo = "2nd Book Title",
                        Descripcion = "2nd Book Description",
                        IsRead = true,
                        DateRead = DateTime.Now.AddDays(-10),
                        Rate = 4,
                        Genero = "Biography",
                        Autor = "2nd Author",
                        CoverUrl = "https...",
                        DateAdded = DateTime.Now,
                    });
                    context.SaveChanges();
                }
            }
        }


    }
}
