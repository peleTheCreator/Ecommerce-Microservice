using Ecommerce.UserMS.Application;
using Ecommerce.UserMS.Domain;
using Ecommerce.UserMS.Persistance;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace Ecommerce.UserMS.DependencyInjection;

public static class DependencyInjectionExtension
{
    public static void AddUserMS(this IServiceCollection services, WebApplicationBuilder builder)
    {
        services.AddDomain(builder);
        services.AddApplicationService(builder);
        services.AddPersistance(builder);
    }
}



