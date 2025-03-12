using Ecommerce.UserMS.Domain.Mapper;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace Ecommerce.UserMS.Domain
{
    public static class DependencyInjectionExtension
    {
        public static void AddDomain(this IServiceCollection services, WebApplicationBuilder builder)
        {
            builder.Services.AddAutoMapper(typeof(ApplicationUserMappingProfile).Assembly);
            //FluentValidations
            builder.Services.AddFluentValidationAutoValidation();

        
        }
    }

}
