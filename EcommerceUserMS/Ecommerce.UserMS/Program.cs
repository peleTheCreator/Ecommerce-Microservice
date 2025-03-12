using System.Text.Json.Serialization;
using Ecommerce.UserMS.API.Middleware;
using Ecommerce.UserMS.DependencyInjection;
var builder = WebApplication.CreateBuilder(args);


// Add controllers to the service collection
builder.Services.AddControllers().AddJsonOptions(options => {
    options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
});
builder.Services.AddUserMS(builder);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(builder => {
        builder.WithOrigins("http://localhost:4200")
        .AllowAnyMethod()
        .AllowAnyHeader();
    });
});
var app = builder.Build();
// Configure the HTTP request pipeline.
app.ConfigureMiddleware();
app.Run();
public static class ApplicationExtensions
{
    public static void ConfigureMiddleware(this WebApplication app)
    {
        app.UseExceptionHandlingMiddleware();
        app.UseRouting();
        app.UseSwagger(); 
        app.UseSwaggerUI(); 
        app.UseCors();
        app.UseAuthentication();
        app.UseAuthorization();
        app.MapControllers();
        app.Run();

    }
}
