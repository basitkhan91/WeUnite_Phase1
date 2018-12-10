using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Reach.Repository;
using Reach.Entity;
using Newtonsoft.Json.Serialization;

namespace Reach.API
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
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1)
                    .AddJsonOptions(x => {
                if(x.SerializerSettings.ContractResolver != null)
                {
                            var defaultContractResolver = x.SerializerSettings.ContractResolver as DefaultContractResolver;
                            defaultContractResolver.NamingStrategy = null;
                }

                    });

            services.AddTransient<IUnitOfWork,UnitOfWork>();

            services.AddDbContext<ReachContext>(options =>
                                                options.UseMySql("server=127.0.0.1;uid=root;pwd=admin@2018;database=ReachTest"));
           
            //services.AddDbContext<ReachContext>(x => x.Use)
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {

            //Reach.Repository.TuteeData.Seed1(context);

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
