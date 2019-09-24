using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace XLogger
{
    public static class WebHostBuilderExtensions
    {
        /// <summary>
        /// Sets XLogger as the logging provider.
        /// </summary>
        /// <param name="builder">The web host builder to configure.</param>
        /// <param name="loggerHubOptions">The logger hub options and preferences.</param>
        /// <returns>The web host builder.</returns>
        public static IWebHostBuilder UseXLogger(this IWebHostBuilder builder, Action<ILoggerHub> loggerHubOptions) =>
            builder.ConfigureLogging((hostingContext, logging) => logging.RegisterLoggerHub(loggerHubOptions));

        /// <summary>
        /// Sets XLogger as the logging provider.
        /// </summary>
        /// <param name="builder">The host builder to configure.</param>
        /// <param name="loggerHubOptions">The logger hub options and preferences.</param>
        /// <returns>The host builder.</returns>
        public static IHostBuilder UseXLogger(this IHostBuilder builder, Action<ILoggerHub> loggerHubOptions) =>
            builder.ConfigureLogging((hostingContext, logging) => logging.RegisterLoggerHub(loggerHubOptions));
    }
}   