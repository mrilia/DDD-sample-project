using TravelChecklist.Application.Services;
using TravelChecklist.Infrastructure.EF;
using TravelChecklist.Infrastructure.Services;
using TravelChecklist.Shared.Abstractions.Commands;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TravelChecklist.Shared.Queries;
using TravelChecklist.Infrastructure.Logging;

namespace TravelChecklist.Infrastructure
{
    public static class Extensions
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddSQLDB(configuration);
            services.AddQueries();
            services.AddSingleton<IWeatherService, DumbWeatherService>();

            services.TryDecorate(typeof(ICommandHandler<>), typeof(LoggingCommandHandlerDecorator<>));

            return services;
        }
    }
}
