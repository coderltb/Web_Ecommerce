using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using StackExchange.Redis;
using Volo.Abp;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundWorkers;
using Volo.Abp.Caching;
using Volo.Abp.Caching.StackExchangeRedis;
using Volo.Abp.Modularity;
using Web_ECommerce.BackgroundWorkers.MailCampaigns;
using Web_ECommerce.EntityFrameworkCore;

namespace Web_ECommerce.BackgroundWorkers
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(AbpBackgroundWorkersModule),
        typeof(Web_ECommerceEntityFrameworkCoreModule),
        typeof(AbpCachingStackExchangeRedisModule)
    )]
    public class Web_ECommerceBackgroundWorkersModule: AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            var configuration = context.Services.GetConfiguration();
            var hostEnvironment = context.Services.GetSingletonInstance<IHostEnvironment>();

            context.Services.AddHostedService<WebECommerceBackgroundWorkersHostedService>();

            Configure<AbpDistributedCacheOptions>(options =>
            {
                options.KeyPrefix = "WebECommerce:";
            });
            var dataProtectionBuilder = context.Services.AddDataProtection().SetApplicationName("WebECommerce");
            if (!hostEnvironment.IsDevelopment())
            {
                var redis = ConnectionMultiplexer.Connect(configuration["Redis:Configuration"]);
                dataProtectionBuilder.PersistKeysToStackExchangeRedis(redis, "WebECommerce-Protection-Keys");
            }

        }

        public override void OnApplicationInitialization(ApplicationInitializationContext context)
        {
            context.AddBackgroundWorkerAsync<EmailMarketingWorker>();
        }
    }
}