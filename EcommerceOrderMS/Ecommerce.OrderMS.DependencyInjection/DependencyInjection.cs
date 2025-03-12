using Ecommerce.OrderMS.Application;
using Ecommerce.OrderMS.Domain;
using Ecommerce.OrderMS.Persistance;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace Ecommerce.OrderMS.DependencyInjection;

public static class DependencyInjectionExtension
{
    public static void AddOrderMS(this IServiceCollection services, WebApplicationBuilder builder)
    {
        services.AddDomain(builder);
        services.AddApplicationService(builder);
        services.AddPersistance(builder);
    }
}
