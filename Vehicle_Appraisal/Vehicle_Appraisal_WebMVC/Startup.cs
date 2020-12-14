using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using Vehicle_Appraisal_WebApi.Infracstructure.ValidatorDTO;
using Vehicle_Appraisal_WebMVC.Service;
using Vehicle_Appraisal_WebMVC.Service.Class;
using Vehicle_Appraisal_WebMVC.Service.Interface;
using Vehicle_Appraisal_WebMVC.Validator;

namespace Vehicle_Appraisal_WebMVC
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
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });
            // add authentication
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(Option =>
            {
                Option.LoginPath = "/user/login";
            });

            // add DI
            services.AddHttpClient();
            services.AddTransient<IVehicleServiceApiClient, VehicleServiceApiClient>();
            services.AddTransient<ICustomerServiceApiClient, CustomerServiceApiClient>();
            services.AddTransient<IModelServiceApiClient, ModelServiceApiClient>();
            services.AddTransient<IMakeServiceApiClient, MakeServiceApiClient>();
            services.AddTransient<IUserServiceApiClient, UserServiceApiClient>();
            services.AddTransient<IVehicleAppraisalServiceApiClient, VehicleAppraisalServiceApiClient>();
            services.AddTransient<IConditionServiceApiClient, ConditionServiceApiClient>();
            services.AddTransient<IVehicleCrawlDataServiceApiClient, VehicleCrawlDataServiceApiClient>();
            services.AddTransient<IUserRoleServiceApiClient, UserRoleServiceApiClient>();

            services.AddMemoryCache();
            // add session
            services.AddSession(opt =>
            {
                opt.IdleTimeout = TimeSpan.FromDays(7);
                opt.Cookie.HttpOnly = true;
                opt.Cookie.IsEssential = true;
            });

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2)
                             // add fluent validation
                             .AddFluentValidation(fv => fv.RegisterValidatorsFromAssemblyContaining<RegisterValidator>())
                             .AddFluentValidation(fv => fv.RegisterValidatorsFromAssemblyContaining<AppUserModelMVCValidator>());
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseAuthentication();
            app.UseSession();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
            app.UseCookiePolicy();

        }
    }
}
