using eShopSolution.Application.Catalog.Products.Implements;
using eShopSolution.Application.Catalog.Products.Interfaces;
using eShopSolution.Application.Common;
using eShopSolution.Application.System.Users;
using eShopSolution.Data.EF;
using eShopSolution.Data.Entities;
using eShopSolution.Utilities;
using eShopSolution.ViewModels.Validator.Users;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace eShopSolution.BackendApi
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
            services.AddCors();
            // Connection Db
            services.AddDbContext<EShopDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString(SystemConstants.MainConnectionString)));

            // Identity
            services.AddIdentity<AppUser, AppRole>()
                .AddEntityFrameworkStores<EShopDbContext>()
                .AddDefaultTokenProviders();

            // Declare DI
            services.AddTransient<IFileStorageService, FileStorageService>();
            services.AddTransient<IProductService, ProductService>();
            services.AddTransient<IUserService, UserService>();
            services.AddTransient<UserManager<AppUser>, UserManager<AppUser>>();
            services.AddTransient<SignInManager<AppUser>, SignInManager<AppUser>>();
            services.AddTransient<RoleManager<AppRole>, RoleManager<AppRole>>();

            services.AddControllers()
                .AddFluentValidation(fv => fv.RegisterValidatorsFromAssemblyContaining<LoginRequestValidator>());

            // Add Swagger
            services.ConfigureSwagger();

            // configure JWT
            services.ConfigureJWT(Configuration);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseCors(opt =>
            {
                opt.AllowAnyHeader();
                opt.AllowAnyMethod();
                opt.AllowAnyOrigin();
            });
            app.UseHttpsRedirection();

            app.UseAuthentication();

            app.UseRouting();

            app.UseAuthorization();

            app.UseSwagger();

            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "eShopSolution V1");
            });

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapDefaultControllerRoute();
            });
        }
    }
}