using Ecommerce.OrderMS.Application.Persisitance.Abstraction;
using Ecommerce.OrderMS.Persistance.Concrete;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MongoDB.Driver;

namespace Ecommerce.OrderMS.Persistance
{
    public static class DependencyInjectionExtension
    {
        public static void AddPersistance(this IServiceCollection services, WebApplicationBuilder builder)
        {
            string connectionStringTemplate = builder.Configuration.GetConnectionString("MongoDB")!;
            string connectionString = connectionStringTemplate
              .Replace("$MONGO_HOST", Environment.GetEnvironmentVariable("MONGODB_HOST"))
              .Replace("$MONGO_PORT", Environment.GetEnvironmentVariable("MONGODB_PORT"));

            services.AddSingleton<IMongoClient>(new MongoClient(connectionString));

            services.AddScoped<IMongoDatabase>(provider =>
            {
                IMongoClient client = provider.GetRequiredService<IMongoClient>();
                return client.GetDatabase(Environment.GetEnvironmentVariable("MONGODB_DATABASE"));
            });

            services.AddScoped<IOrdersRepository, OrdersRepository>();
        }
    }
}
