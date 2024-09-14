using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using RegisterMVCAPP.Contexts;
using RegisterMVCAPP.Models;

namespace RegisterMVCAPP
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddDbContext<RegisterMVCAPPDBContext>(options =>
               options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultCS")));

            // Add services to the container.
            builder.Services.AddControllersWithViews();
      
            builder.Services.AddIdentity<ApplicationUser, IdentityRole>()
    .AddEntityFrameworkStores<RegisterMVCAPPDBContext>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
