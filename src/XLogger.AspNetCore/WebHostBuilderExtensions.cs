using System;
using Microsoft.AspNetCore.Hosting;

namespace XLogger
{
    public static class WebHostBuilderExtensions
    {
        public static IWebHostBuilder UseXLogger(this IWebHostBuilder builder, Action<ILoggerHub> loggerHubOptions) =>
            builder.ConfigureLogging((hostingContext, logging) => logging.RegisterLoggerHub(loggerHubOptions));
    }
}   