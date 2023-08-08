global using System;
global using System.Collections.Generic;
global using System.Linq;
global using Microsoft.EntityFrameworkCore;
global using Microsoft.AspNetCore.Builder;
global using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using DoctorOffice.Models;

namespace DoctorOffice;

public class Program
{
    public static void Main(string[] args)
    {
        WebApplicationBuilder builder = WebApplication.CreateBuilder(args);
        builder.Services.AddControllersWithViews();
        builder.Services.AddDbContext<DoctorOfficeContext>(
            dbContextOptions => dbContextOptions.UseMySql(
                builder.Configuration["ConnectionStrings:DefaultConnection"],
                ServerVersion.AutoDetect(builder.Configuration["ConnectionStrings:DefaultConnection"])
            )
        );
        WebApplication app = builder.Build();

        DataInitializer.Init(app);

        // app.UseDeveloperExceptionPage();
        app.UseHttpsRedirection();
        app.UseStaticFiles();
        app.UseRouting();

        app.MapControllerRoute(
            name: "default",
            pattern: "{controller=Home}/{action=Index}/{id?}"
        );
        app.Run();
    }
}