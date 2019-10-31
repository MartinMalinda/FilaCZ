using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HelloDI.Controllers;
using HelloDI.Interfaces;
using HelloDI.Models;
using HelloDI.Models.Colors;
using HelloDI.Views;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace HelloDI
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc(); //every time creating MVC
            services.AddTransient<ConsoleLoggerMiddleware>();
            services.AddSingleton<Printer>(); //to create instance of printer
            services.AddSingleton<UtilityService>();
            services.AddSingleton<EmailValidation>();
            services.AddSingleton<IColor, BlueColor>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }


            app.UseMvc(); //every time creating MVC
            app.UseMiddleware<ConsoleLoggerMiddleware>();

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Hello World!");
            });
        }
    }
}
