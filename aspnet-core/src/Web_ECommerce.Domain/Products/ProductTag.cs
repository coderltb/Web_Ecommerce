﻿using System;
using Volo.Abp.Domain.Entities;

namespace Web_ECommerce.Products
{
    public class ProductTag : Entity
    {
        public Guid ProductId { get; set; }
        public string TagId { get; set; }

        public override object[] GetKeys()
        {
            return new object[] { ProductId, TagId };
        }
    }
}
