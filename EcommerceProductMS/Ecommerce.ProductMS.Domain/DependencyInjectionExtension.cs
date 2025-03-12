using Ecommerce.ProductMS.Domain.Mappers;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace Ecommerce.ProductMS.Domain
{
    public static class DependencyInjectionExtension
    {
        public static void AddDomain(this IServiceCollection services, WebApplicationBuilder builder)
        {
            builder.Services.AddAutoMapper(typeof(ProductAddRequestToProductMappingProfile).Assembly);
            //FluentValidations
            builder.Services.AddFluentValidationAutoValidation();


        }
    }

}
