using System.Security.Cryptography.X509Certificates;

namespace MVCSession2G01
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllersWithViews();//Register Built-in MVC Services
            
            var app = builder.Build();

            // app.MapGet("/", () => "Hello World!");
            //// app.MapGet("/login", () => "You Are Sign In!");
            // app.MapGet("/login", () => Signin);

            // MVC
            app.MapControllerRoute(
                name:"default",
                pattern:"{controller=Movie}/{action=GetMovie}/{id?}"
                );


            app.Run();
        }

        public static string Signin()
        {
            return $"You Are Sign In!";
        }

        
    }
}
