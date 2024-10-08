using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Npgsql.EntityFrameworkCore.PostgreSQL;
using Microsoft.EntityFrameworkCore;
//using aspnetapp.DB;
using aspnetapp.Database;

namespace aspnetapp
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            var databaseUrl = Environment.GetEnvironmentVariable("DATABASE_URL");
            if(string.IsNullOrEmpty(databaseUrl))
            {
                databaseUrl = Configuration.GetValue<string>("DATABASE_URL");
            }
            if(!string.IsNullOrEmpty(databaseUrl))
            {
                services.AddDbContext<AppDbContext>(options => options.UseNpgsql(databaseUrl));
            }

            services.AddRazorPages();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, AppDbContext context)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
            });

            //ApplyMigrations(context);
        }

        private void ApplyMigrations(AppDbContext context) 
        {
            //TODO: NOT NEEDED when using migrations
            //context.Database.EnsureCreated();

            if (context.Database.GetPendingMigrations().Any()) 
            {
                context.Database.Migrate();
            }
        }
    }
}
