using Ecommerce.OrderMS.Domain.Mapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace Ecommerce.OrderMS.Domain;

public static class DependencyInjectionExtension
{
    public static void AddDomain(this IServiceCollection services, WebApplicationBuilder builder)
    {
        builder.Services.AddAutoMapper(typeof(OrderItemAddRequestToOrderItemMappingProfile).Assembly);
    }
}
