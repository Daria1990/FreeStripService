using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FreeStripService.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using FreeStripService.Repositories.Concrete;
using FreeStripService.Repositories.Abstract;
using FreeStripService.Weather.Concrete;
using FreeStripService.Weather.Abstract;

namespace FreeStripService
{
    public class Startup
    {
        public IConfiguration Configuration { get; }


        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddGrpc();

            string connection = Configuration.GetConnectionString("DefaultConnection");
            services.AddDbContext<AirTransportContext>(options => options.UseSqlServer(connection));

            services.AddTransient<ProtoModelConverter>();
            services.AddTransient<IWeatherInfluence, WeatherInfluence>();

            services.AddTransient<IPlainModelRepository, PlainModelRepository>();
            services.AddTransient<IPlainTypeRepository, PlainTypeRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGrpcService<PlainInfoService>();
                endpoints.MapGrpcService<PlainModelCRUDService>();
            });
        }
    }
}
