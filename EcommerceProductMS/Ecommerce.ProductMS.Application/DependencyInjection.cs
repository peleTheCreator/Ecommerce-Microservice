using Ecommerce.ProductMS.Application.Service.Abstraction;
using Ecommerce.ProductMS.Application.Service.Concrete;
using Ecommerce.ProductMS.Application.Validators;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace Ecommerce.ProductMS.Application;

public static class DependencyInjection
{
    public static void AddApplicationService(this IServiceCollection services, WebApplicationBuilder builder)
    {
        services.AddTransient<IProductsService, ProductsService>();
        //FluentValidations
       // builder.Services.AddFluentValidationAutoValidation();
        builder.Services.AddValidatorsFromAssemblyContaining<ProductAddRequestValidator>();


    }
}
