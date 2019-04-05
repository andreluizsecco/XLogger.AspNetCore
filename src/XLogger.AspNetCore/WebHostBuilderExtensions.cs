using System;
using XLogger;
using Microsoft.Extensions.DependencyInjection;

namespace Microsoft.AspNetCore.Hosting
{
    public static class WebHostBuilderExtensions
    {
        public static IWebHostBuilder UseXLogger(this IWebHostBuilder builder, Action<ILoggerHub> loggerHubOptions) =>
            builder.ConfigureLogging((hostingContext, logging) => logging.RegisterLoggerHub(loggerHubOptions));
    }
}   