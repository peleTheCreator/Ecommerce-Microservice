using FluentValidation.AspNetCore;
using Ecommerce.ProductMS.DependencyInjection;
using Ecommerce.ProductMS.API.APIEndpoints;
using Ecommerce.ProductMS.API.Middleware;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        //Add DAL and BLL services
        builder.Services.AddProductMS(builder);

        builder.Services.AddControllers()
        .AddJsonOptions(options =>  
        {
            // Configure to serialize enums as strings
            options.JsonSerializerOptions.Converters.Add(new System.Text.Json.Serialization.JsonStringEnumConverter());
        });

        builder.Services.AddEndpointsApiExplorer();

        builder.Services.AddSwaggerGen();



        var app = builder.Build();

        app.UseExceptionHandlingMiddleware();
        app.UseRouting();
        app.UseSwagger();
        app.UseSwaggerUI(options =>
        {
            options.SwaggerEndpoint("/swagger/v1/swagger.json", "Ecommerce Product API V1");
            options.RoutePrefix = string.Empty; 
        });
        //Auth
        app.UseAuthentication();
        app.UseAuthorization();

        app.MapControllers();
        app.MapProductAPIEndpoints();

        app.Run();
    }
}