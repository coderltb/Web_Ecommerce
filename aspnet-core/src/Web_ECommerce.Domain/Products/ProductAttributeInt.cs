﻿using System;
using Volo.Abp.Domain.Entities;

namespace Web_ECommerce.Products
{
    public class ProductAttributeInt : Entity<Guid>
    {
        public Guid AttributeId { get; set; }
        public Guid ProductId { get; set; }
        public int? Value { get; set; }
    }
}