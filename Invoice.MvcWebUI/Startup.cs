using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Invoice.Business.Abstract;
using Invoice.Business.Concrete;
using Invoice.DataAccess;
using Invoice.DataAccess.Abstract;
using Invoice.DataAccess.Concrete.EntityFramework;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Invoice.MvcWebUI
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddScoped<IItemService, ItemManager>();
            services.AddScoped<IItemDal, EfItemDal>();
            services.AddScoped<IClientService, ClientManager>();
            services.AddScoped<IClientDal, EfClientDal>();
            services.AddScoped<IOrderficheService, OrderficheManager>();
            services.AddScoped<IOrderficheDal,EfOrderficheDal>();
            services.AddScoped<IOrderLineService, OrderLineManager>();
            services.AddScoped<IOrderLineDal, EfOrderLineDal>();
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddSession();
            services.AddCors();
            services.AddDistributedMemoryCache();
            services.Configure<FormOptions>(o =>
            {
                o.ValueLengthLimit = int.MaxValue;
                o.MultipartBodyLengthLimit = int.MaxValue;
                o.MemoryBufferThreshold = int.MaxValue;
            });
            services.AddMvc(option => option.EnableEndpointRouting = false);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseHttpsRedirection();
            app.UseCors(builder => builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
            app.UseSession();
            app.UseStaticFiles();
            // app.UseIdentity()
            app.UseMvcWithDefaultRoute();
            app.UseHttpsRedirection();
            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();
        }
    }
}
