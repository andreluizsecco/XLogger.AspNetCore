using System;
using Microsoft.Extensions.Logging;
using XLogger;

namespace Microsoft.AspNetCore.Hosting
{
    public static class WebHostBuilderExtensions
    {
        public static IWebHostBuilder UseXLogger(this IWebHostBuilder builder, Action<ILoggerHub> loggers)
        {
            return builder.ConfigureLogging((hostingContext, logging) =>
            {
                logging.ClearProviders();
                var hub = new LoggerHub(logging.Services);
                loggers.Invoke(hub);
            });
        }
    }
}