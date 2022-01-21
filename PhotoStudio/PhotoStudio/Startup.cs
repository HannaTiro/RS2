using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using PhotoStudio.Data.Requests.Fotograf;
using PhotoStudio.Data.Requests.Grad;
using PhotoStudio.Database;
using PhotoStudio.Filters;
using PhotoStudio.Interface;
using PhotoStudio.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhotoStudio
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
           // services.AddMvc(x => x.Filters.Add<ErrorFilter>());
            services.AddControllers();
            services.AddSwaggerGen();
           services.AddDbContext<PhotoStudioContext>(c => c.UseSqlServer(Configuration.GetConnectionString("PhotoStudio"))
            .EnableSensitiveDataLogging());
            services.AddAutoMapper(typeof(Startup));

            //Dependency injection
            services.AddScoped<IService<Data.Model.Grad, GradSearchRequest>, GradService>();


            services.AddScoped<ICRUDService<Data.Model.Fotograf, FotografSearchRequest, FotografUpsert, FotografUpsert>, FotografService>();
            
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseSwagger();
            app.UseSwaggerUI();

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}