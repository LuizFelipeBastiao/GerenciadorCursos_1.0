using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using GerenciadorCursos;
using GerenciadorCursos.Models;
using System;

namespace GerenciadorCursos
{
    public class Program
    {
        // This is the main entry point of the application.
        public static MauiApp CreateMauiApp()
        {
            // if you want to use a different Application Delegate class from "AppDelegate"
            // you can specify it here.
            //UIApplication.Main(args, null, typeof(AppDelegate));

            var builder = MauiApp.CreateBuilder();

            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

            // Configuração do DbContext com SQLite
            builder.Services.AddDbContext<AppDbContext>(options =>
                options.UseSqlite("Data Source=mydatabase.db"));

            return builder.Build();
        }

    }
}
