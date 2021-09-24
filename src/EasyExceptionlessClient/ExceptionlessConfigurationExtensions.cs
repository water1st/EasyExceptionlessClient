using Exceptionless;
using Exceptionless.Logging;
using System.IO;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class ExceptionlessConfigurationExtensions
    {
        public static IServiceCollection AddExceptionlessLogging(this IServiceCollection services, string apiKey, string serverUrl)
        {
            services.AddLogging(builder =>
            {
                builder.AddExceptionless(options =>
                {
                    options.ApiKey = apiKey;
                    options.ServerUrl = serverUrl;
                    options.SetDefaultMinLogLevel(LogLevel.Trace);
                    var path = Path.Combine(Directory.GetCurrentDirectory(), "logger-storages");
                    options.UseFolderStorage(path);
                });
            });

            return services;
        }
    }
}
