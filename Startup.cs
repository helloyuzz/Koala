using Koala.Models;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;

namespace Koala {
    public class Startup {
        public Startup(IConfiguration configuration) {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services) {
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(x => {
                x.LoginPath = "/Login";
                x.LogoutPath = "/Logout";
                x.AccessDeniedPath = "/AccessDenied";
                x.ReturnUrlParameter = "ReturnUrl";
            });

            services.AddRazorPages().AddRazorRuntimeCompilation();

            var serverVersion = new MySqlServerVersion(new System.Version(5, 7, 32));
            services.AddDbContext<koalaContext>(options => options.EnableSensitiveDataLogging().EnableDetailedErrors());
            // .UseMySql(Configuration.GetConnectionString("MySQL_remote"), serverVersion)

            services.AddSession(a => a.IdleTimeout = TimeSpan.FromMinutes(30));
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddTransient<MenuHelper>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env) {
            if (env.IsDevelopment()) {
                app.UseDeveloperExceptionPage();
            } else {
                app.UseExceptionHandler("/Error");
            }
            DefaultFilesOptions defaultFilesOptions = new DefaultFilesOptions();
            defaultFilesOptions.DefaultFileNames.Clear();
            defaultFilesOptions.DefaultFileNames.Add("Login.html");
            app.UseDefaultFiles(defaultFilesOptions);

            app.UseStaticFiles();
            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();
            app.UseSession();

            app.UseEndpoints(endpoints =>
            {              
                endpoints.MapRazorPages();
            });
        }
    }
}