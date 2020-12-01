using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Internal;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using org.omg.IOP;
using Vehicle_Appraisal_WebApi.AutoMapper;
using Vehicle_Appraisal_WebApi.DALs;
using Vehicle_Appraisal_WebApi.DTOs;
using Vehicle_Appraisal_WebApi.Infrastructure.InterfaceService;
using Vehicle_Appraisal_WebApi.Service;
using FluentValidation.AspNetCore;
using Vehicle_Appraisal_WebApi.Infracstructure.ValidatorDTO;

namespace Vehicle_Appraisal_WebApi
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

            // DB connection string (My SQL Server)
            services.AddDbContext<DbContextDTO>(opt =>
            opt.UseSqlServer(Configuration.GetConnectionString("VehicleAppraisal")));

            // Validator

            // automapper
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new AutoMapperConfigure());
            });
            IMapper mapper = config.CreateMapper();
            services.AddSingleton(mapper);

            // add DI  
            services.AddScoped<IMakeService,MakeService>();
            services.AddScoped<IModelService,ModelService>();
            services.AddScoped<ICustomerService, CustomerService>();
            services.AddScoped<IVehicleService, VehicleService>();
            services.AddScoped<IConditionService, ConditionService>();
            services.AddScoped<IVehicleAppraisalService, VehicleAppraisalService>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IUserRoleService, UserRoleService>();
            services.AddScoped<IAccountService, AccountService>();
            services.AddScoped<IEmailService, EmailService>();
            services.AddScoped<IVehicleCrawlDataService, VehicleCrawlDataService>();

            // authentication
            services.AddAuthentication(option =>
            {
                option.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                option.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
                .AddJwtBearer(Opt =>
                {
                    var secretKey = new SymmetricSecurityKey(UTF8Encoding.UTF8.GetBytes(Configuration["JWT:SecretKey"]));
                    Opt.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateIssuer = true,
                        ValidateAudience = true,
                        ValidateIssuerSigningKey = true,
                        IssuerSigningKey = secretKey,
                        ValidIssuer = Configuration["JWT:Issuer"],
                        ValidAudience = Configuration["JWT:Audience"],
                        ValidateLifetime = true
                    };
                });

            // swagger
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "My Api", Version = "v1" });
                c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
                {
                    Description = @"JWT Authorization header using the Bearer scheme. \r\n\r\n 
                      Enter 'Bearer' [space] and then your token in the text input below.
                      \r\n\r\nExample: 'Bearer 12345abcdef'",
                    Name = "Authorization",
                    In = ParameterLocation.Header,
                    Type = SecuritySchemeType.ApiKey,
                    Scheme = "Bearer"
                });
                c.AddSecurityRequirement(new OpenApiSecurityRequirement()
                {
                    {
                        new OpenApiSecurityScheme
                        {
                            Reference = new OpenApiReference
                            {
                                Type = ReferenceType.SecurityScheme,
                                Id = "Bearer"
                            },
                            Scheme = "Bearer",
                            Name = "Bearer",
                            In = ParameterLocation.Header,
                        },
                        new List<string>()
                    }
                });
            });

            services.AddMvc()
                .SetCompatibilityVersion(CompatibilityVersion.Version_2_2)
                // add fluent validation
                .AddFluentValidation(fv => fv.RegisterValidatorsFromAssemblyContaining<RegisterValidator>());
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
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseCors();

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My v1 WebApi");
            });

            app.UseStaticFiles();
            app.UseAuthentication();
            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
