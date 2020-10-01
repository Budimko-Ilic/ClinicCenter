using ClinicalCenter.Contracts;
using ClinicalCenter.Entities;
using ClinicalCenter.Repository;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicalCenter
{
    public static class ServiceExtensions
    {
        public static void ConfigureSqlServerContext(this IServiceCollection services, IConfiguration Configuration)
        {
            var connectionString = Configuration["sqlserverconnection:ConnectionStr"];
            services.AddDbContext<RepositoryContext>(o => o.UseSqlServer(connectionString));
        }
        public static void ConfigureIISIntegration(this IServiceCollection services)
        {
            services.Configure<IISOptions>(options =>
            {

            });
        }
        public static void ConfigureRepositoryWrapper(this IServiceCollection services)
        {
            services.AddScoped<IRepositoryWrapper, RepositoryWrapper>();
        }
    }
}
