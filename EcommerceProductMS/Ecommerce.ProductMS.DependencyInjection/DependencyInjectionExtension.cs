using Ecommerce.ProductMS.Application;
using Ecommerce.ProductMS.Domain;
using Ecommerce.ProductMS.Persistance;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace Ecommerce.ProductMS.DependencyInjection;
public static class DependencyInjectionExtension
{
    public static void AddProductMS(this IServiceCollection services, WebApplicationBuilder builder)
    {
        services.AddDomain(builder);
        services.AddApplicationService(builder);
        services.AddPersistance(builder.Configuration);
    }
}



