using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;



namespace INVOICE_WEB_DAG
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
             services.AddDbContext<DatabaseContext>(options =>
                  options.UseNpgsql(
            "Host=ec2-54-83-9-36.compute-1.amazonaws.com;" +
            "Database=dat7lgnog7mtl2;"+
            "Password=89efd7d3a3cd4d5a90b7fdeb3747fda4a53ed6d17d73ee01e572d9c71f0a3252;"+
            "Port=5432;SSL Mode=Require;Trust Server Certificate=true")
                  ); 
        } 

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
           app.UseStaticFiles();
           if(env.IsDevelopment()){
               app.UseDeveloperExceptionPage();

           }
           app.UseMvc(routes =>{
               routes.MapRoute(
                   name: "defauld",
                   template: "{controller=Home}/{action=Index}/{id?}"
               );
           });
        }
    }
}
