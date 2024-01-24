using Catalogue.DomainLayer.IReposistory;
using Catalogue.InfastructureLayer.Data;
using Catalogue.InfastructureLayer.Reposistory;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalogue.InfastructureLayer
{
    public static class ConfigureServices
    {
        public static IServiceCollection AddInfrastructureServices
            (this IServiceCollection services, IConfiguration configuration)

        {
            services.AddDbContext<ProductDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("ProductDbContext") ??
                    throw new InvalidOperationException("connection string 'BlogBbContext not found '")));
            
            services.AddTransient<IProductRepository,ProductRepository>();


            return services;

        }
    }
}

