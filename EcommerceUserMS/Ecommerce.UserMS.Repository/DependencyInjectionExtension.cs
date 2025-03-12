using Ecommerce.UserMS.Application.Persisitance.Abstraction;
using Ecommerce.UserMS.Persistance.Concrete;
using Ecommerce.UserMS.Persistance.DbContext;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace Ecommerce.UserMS.Persistance
{
    public static class DependencyInjectionExtension
    {
        public static void AddPersistance(this IServiceCollection services, WebApplicationBuilder builder)
        {
            services.AddTransient<IUsersRepository, UsersRepository>();

            services.AddTransient<DapperDbContext>();
        }
    }
}
