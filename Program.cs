namespace OsnoveCSharp4_API1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();

            app.MapGet("/", () => "Zdravo!");
            app.MapPut("/", () => "Ovo je PUT zahtev - zahtev za izmenu podataka u aplikaciji.");
            app.MapDelete("/", () => "Ovo je DELETE zahtev - zahtev za brisanje podataka u aplikaciji.");
            app.MapPost("/", () => "Ovo je POST zahtev - zahtev za ubacivanje podataka u aplikaciju.");

            app.Run();
        }
    }
}
