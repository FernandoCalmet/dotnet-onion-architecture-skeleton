using Microsoft.Extensions.DependencyInjection;

namespace MyCompany.MyProduct.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        return services;
    }
}