using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entity.Contexts;
using Microsoft.EntityFrameworkCore;
using Tasarim_Bolumu.Areas.Admin.Identity;

namespace Tasarim_Bolumu.Extension
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection IdentityServerAyarlari(this IServiceCollection services)
        {
            services.AddDbContext<SqlIdentityContext>(opt => opt.UseSqlServer("Server=(localdb)\\MsSqlLocalDb;Database=ETicaret;Trusted_Connection=true"));

            services.AddIdentity<CustomUser, IdentityRole>()
                       .AddEntityFrameworkStores<SqlIdentityContext>() // Hangi Database ile calisacagini belirtiyoruz
                       .AddDefaultTokenProviders(); // email confirm yada parola degisikligi esnasinda uretilecek olan token degerini verir.

            services.Configure<IdentityOptions>(options =>
            {
                options.Password.RequireDigit = true; // Sifre icerisinde rakam olsun mu ?
                options.Password.RequireLowercase = true; // Kucuk harf olsun mu ?
                options.Password.RequiredLength = 6; // Sifre kac karakterli olsun ?
                options.Password.RequireNonAlphanumeric = true;///. @ tarzı karakter olmalı
                options.Lockout.MaxFailedAccessAttempts = 5; // Kac kere yanlis girebilir
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(10); // 10 dakika boyunca yeni giris yapamaz

                options.User.AllowedUserNameCharacters = "abcçdefgğhıijklmnoöpqrsştuüvwxyzABCÇDEFGĞHIİJKLMNOÖPQRSTUÜVWXYZ0123456789-._@+";

                options.User.RequireUniqueEmail = true;




            });


            return services;
        }

        public static IServiceCollection CookieAyarlari(this IServiceCollection services)
        {

            services.ConfigureApplicationCookie(options =>
            {
                options.LoginPath = "/Admin/Account/Login"; // Default Login Ekrani 
                options.LogoutPath = "/Admin/Account/Logout";
                options.AccessDeniedPath = "/Admin/Account/AccessDenied";
                options.SlidingExpiration = false;   //Default time 20 dakika. 20 dk. bir şey yapmazsa üye atılır

                options.Cookie.HttpOnly = true; // Guvenlik ile ilgili . Tarayicimizdaki diger scriptler cookie'yi okuyamasin.
                options.Cookie.Name = "Admin";
                options.Cookie.SameSite = Microsoft.AspNetCore.Http.SameSiteMode.Strict; // Bizim tarayicimiz disindaki kullanimi engeller
                options.ExpireTimeSpan = TimeSpan.FromMinutes(60); // Cookie nin gecerlilik suresi


            });

            return services;
        }
    }
}
