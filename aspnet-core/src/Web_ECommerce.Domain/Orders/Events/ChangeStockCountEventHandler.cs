﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;
using Volo.Abp.EventBus;

namespace Web_ECommerce.Orders.Events
{
    public class ChangeStockCountEventHandler : ILocalEventHandler<NewOrderCreatedEvent>,
        ITransientDependency
    {
        public async Task HandleEventAsync(NewOrderCreatedEvent eventData)
        {
            // Handler when create new order --> Change current product stock
        }
    }
}