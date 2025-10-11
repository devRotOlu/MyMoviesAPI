using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Npgsql;
using System.Data;


namespace MyMovies.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, ConfigurationManager configuration)
        {
            services.ConfigureDBContext(configuration);

            return services;
        }

        private static IServiceCollection ConfigureDBContext(this IServiceCollection services, ConfigurationManager configuration)
        {
            services.AddScoped<IDbConnection>(sp =>
            {
                var connection = new NpgsqlConnection(configuration.GetConnectionString("DefaultConnection"));
                connection.Open();
                return connection;
            });

            return services;
        }
    }
}
