using Microsoft.Extensions.DependencyInjection;

namespace MedCard.Aplication;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(
        this IServiceCollection service)
    {
        return service;
    }
}