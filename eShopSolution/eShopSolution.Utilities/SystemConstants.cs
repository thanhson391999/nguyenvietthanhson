using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Utilities
{
    public static class SystemConstants
    {
        public const string MainConnectionString = "eShopSolutionDb";

        public static void ConfigureJWT(this IServiceCollection service, IConfiguration configuration)
        {
            string issuer = configuration.GetValue<string>("JWT:Issuer");
            string audience = configuration.GetValue<string>("JWT:Audience");
            string signingKey = configuration.GetValue<string>("JWT:SecretKey");
            byte[] signingKeyBytes = Encoding.UTF8.GetBytes(signingKey);

            service.AddAuthentication(opt =>
            {
                opt.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                opt.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            .AddJwtBearer(opt =>
            {
                opt.RequireHttpsMetadata = false;
                opt.SaveToken = true;
                opt.TokenValidationParameters = new TokenValidationParameters()
                {
                    ValidateIssuer = true,
                    ValidIssuer = issuer,
                    ValidateAudience = true,
                    ValidAudience = audience,
                    ValidateLifetime = true,
                    ValidateIssuerSigningKey = true,
                    ClockSkew = TimeSpan.Zero,
                    IssuerSigningKey = new SymmetricSecurityKey(signingKeyBytes)
                };
            });
        }
    }
}