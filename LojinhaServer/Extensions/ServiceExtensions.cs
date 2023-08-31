using LojinhaServer.Models;
using MongoDB.Driver;

namespace LojinhaServer.Extensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureCors(this IServiceCollection services)
        {
            services.AddCors(options => {
                options.AddPolicy("CorsPolicy",
                builder => builder.AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader()
                );
            });
        }
    }

    public static void ConfigureMongoDBSettings(this IServiceCollection serives, IConfiguration config)
    {
        ServiceExtensions.Configure<MongoDBSettings>(
            config.GetSection("MongoDBSettings")
        );

        services.Addingleton<IMongoDatabase>(options =>{
        var settings = config.GetSection("MongoDB").Get<MongoDBSettings>();
        var client = new MongoClient(settings.ConnectionString);
        return client.GetDatabase(settings.DatabaseName);
    });
    }
}