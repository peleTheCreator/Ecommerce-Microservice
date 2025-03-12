using Ecommerce.UserMS.Application.Service.Abstraction;
using Ecommerce.UserMS.Application.Service.Concrete;
using FluentValidation;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace Ecommerce.UserMS.Application
{
    public static class DependencyInjectionExtension
    {
        public static void AddApplicationService(this IServiceCollection services, WebApplicationBuilder builder)
        {
            services.AddTransient<IUsersService, UsersService>();
        }
    }
}
