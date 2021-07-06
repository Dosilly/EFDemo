using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using TestApp.Application.Abstractions;
using TestApp.Application.Users.Abstractions;
using TestApp.Application.Users.Handlers;
using TestApp.Infrastructure.Contexts;
using TestApp.Infrastructure.Repositories;

namespace TestApp.WebApp
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
            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo {Title = "TestApp.WebApp", Version = "v1"});
            });

            // Register services
            services.AddScoped<IUsersHandler, UsersHandler>();
            services.AddScoped<IUsersRepository, UsersRepository>();

            // Register DbContexts
            services.AddDbContext<UsersContext>(
                options =>
                    options.UseSqlServer(
                        Configuration.GetConnectionString("UsersDatabase"),
                        x => x.MigrationsAssembly("TestApp.WebApp")));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "TestApp.WebApp v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints => { endpoints.MapControllers(); });
        }
    }
}