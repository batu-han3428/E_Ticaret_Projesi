using BL.Concrete;
using BL.Models;
using DAL.Concrete;
using DAL.Models;
using Entity.Contexts;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tasarim_Bolumu.Extension;

namespace Tasarim_Bolumu
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services) {

            //services.Configure<RazorViewEngineOptions>(options =>
            //{
            //    options.ViewLocationExpanders.Add(new CustomLocationExpander());
            //});

            services.AddControllersWithViews();
            services.IdentityServerAyarlari();
            services.CookieAyarlari();

            services.AddScoped<IsiteReklamRepository, siteReklamRepository>();
            services.AddScoped<IsiteReklamServices, siteReklamServices>();

            services.AddScoped<IsliderRepository, sliderRepository>();
            services.AddScoped<IsliderServices, sliderServices>();

            services.AddScoped<IgununFirsatiFotoRepository, gununFirsatiFotoRepository>();
            services.AddScoped<IgununFirsatiFotoServices, gununFirsatiFotoServices>();

            //services.AddScoped<IsliderKartiVeNormalKartRepository, sliderKartiVeNormalKartRepository>();
            services.AddScoped<IsliderKartiVeNormalKartServices, sliderKartiVeNormalKartServices>();

            services.AddScoped<IpcReklamRepository, pcReklamRepository>();
            services.AddScoped<IpcReklamServices, pcReklamServices>();

            services.AddScoped<ItanitimKartRepository, tanitimKartRepository>();
            services.AddScoped<ItanitimKartServices, tanitimKartServices>();

            services.AddScoped<IkategorilerRepository, kategorilerRepository>();
            services.AddScoped<IkategorilerServices, kategorilerServices>();

            services.AddScoped<IustAlanRepository, ustAlanRepository>();
            services.AddScoped<IustAlanServices, ustAlanServices>();

            services.AddScoped<IsiteLogoRepository, siteLogoRepository>();
            services.AddScoped<IsiteLogoServices, siteLogoServices>();

            services.AddScoped<IsiparisHattiRepository,siparisHattiRepository>();
            services.AddScoped<IsiparisHattiServices, siparisHattiServices>();

            services.AddScoped<IodemeSecenekleriRepository, odemeSecenekleriRepository>();
            services.AddScoped<IodemeSecenekleriServices, odemeSecenekleriServices>();

            services.AddScoped<IalisverisKredisiSecenekleriRepository, alisverisKredisiSecenekleriRepository>();
            services.AddScoped<IalisverisKredisiSecenekleriServices, alisverisKredisiSecenekleriServices>();

            services.AddScoped<IbilgiRepository, bilgiRepository>();
            services.AddScoped<IbilgiServices, bilgiServices>();

            services.AddScoped<IaciklamaMetniRepository, aciklamaMetniRepository>();
            services.AddScoped<IaciklamaMetniServices, aciklamaMetniServices>();

            services.AddScoped<IkategoriAlanlariRepository, kategoriAlanlariRepository>();
            services.AddScoped<IkategoriAlanlariServices, kategoriAlanlariServices>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();

            app.UseAuthorization();


               app.UseEndpoints(endpoints =>
            {
                app.UseEndpoints(endpoints =>
                {
                    endpoints.MapControllerRoute(
                      name: "areas",
                      pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"

                    );

                });

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
