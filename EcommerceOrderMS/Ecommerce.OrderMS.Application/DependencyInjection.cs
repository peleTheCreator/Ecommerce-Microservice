using Ecommerce.OrderMS.Application.HttpClients;
using Ecommerce.OrderMS.Application.Service.Abstraction;
using Ecommerce.OrderMS.Application.Service.Concrete;
using Ecommerce.OrderMS.Application.Validators;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace Ecommerce.OrderMS.Application;

public static class DependencyInjection
{
    public static void AddApplicationService(this IServiceCollection services, WebApplicationBuilder builder)
    {

        services.AddFluentValidationAutoValidation();

        services.AddValidatorsFromAssemblyContaining<OrderAddRequestValidator>();

        services.AddHttpClient<UsersMicroserviceClient>(client => {
            client.BaseAddress = new Uri($"http://{builder.Configuration["UsersMicroserviceName"]}:{builder.Configuration["UsersMicroservicePort"]}");
        });

        services.AddHttpClient<ProductsMicroserviceClient>(client => {
            client.BaseAddress = new Uri($"http://{builder.Configuration["ProductsMicroserviceName"]}:{builder.Configuration["ProductsMicroservicePort"]}");
        });


        services.AddTransient<IOrdersService, OrdersService>();

    }
}
