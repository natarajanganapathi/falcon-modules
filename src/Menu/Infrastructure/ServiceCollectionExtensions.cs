namespace Falcon.Menu.Infrastructure;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        // services.AddScoped<IMenuRepository, MenuRepository>();
        // services.AddScoped<IMenuService, MenuService>();
        return services;
    }
}