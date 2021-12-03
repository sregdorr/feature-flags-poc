using System;
using Microsoft.Extensions.Configuration;

namespace Alcoms.Config
{
    public static class ConfigurationExtensions
    {
        public static IConfigurationBuilder AddAlcomsConfig(
            this IConfigurationBuilder builder,
            string appId,
            string environment,
            string profileId = null)
        {
            builder.AddAppConfig(
                "AlcomsCommon",
                environment,
                "FeatureFlags",
                TimeSpan.FromSeconds(20));
            builder.AddAppConfig(
                appId,
                environment,
                profileId ?? "app.settings",
                TimeSpan.FromSeconds(20));

            return builder;
        }
    }
}
