using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Extensions.Hosting;
using Volo.Abp;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundWorkers;
using Volo.Abp.Caching.StackExchangeRedis;
using Volo.Abp.Modularity;
using Web_ECommerce.EntityFrameworkCore;

namespace Web_ECommerce.BackgroundWorkers
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(AbpBackgroundWorkersModule),
        typeof(Web_ECommerceEntityFrameworkCoreModule),
        typeof(AbpCachingStackExchangeRedisModule)
    )]
    internal class WebECommerceBackgroundWorkersHostedService : IHostedService
    {
        private readonly IAbpApplicationWithExternalServiceProvider _application;
        private readonly IServiceProvider _serviceProvider;

        public WebECommerceBackgroundWorkersHostedService(
            IAbpApplicationWithExternalServiceProvider application,
            IServiceProvider serviceProvider)
        {
            _application = application;
            _serviceProvider = serviceProvider;
        }

        public Task StartAsync(CancellationToken cancellationToken)
        {
            _application.Initialize(_serviceProvider);

            return Task.CompletedTask;
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            _application.Shutdown();

            return Task.CompletedTask;
        }
    }
}