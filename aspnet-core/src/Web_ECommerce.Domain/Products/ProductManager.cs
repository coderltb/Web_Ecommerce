﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Domain.Services;
using Web_ECommerce.ProductCategories;

namespace Web_ECommerce.Products
{
    public class ProductManager : DomainService
    {
        private readonly IRepository<Product, Guid> _productRepository;
        private readonly IRepository<ProductCategory, Guid> _productCategoryRepository;
        public ProductManager(IRepository<Product,Guid> productRepository,
            IRepository<ProductCategory, Guid> productCategoryRepository)
        {
            _productCategoryRepository = productCategoryRepository;
            _productRepository = productRepository;
        }

        public async Task<Product> CreateAsync(Guid manufacturerId,
            string name, string code, string slug,
            ProductType productType, string sKU,
            int sortOrder, bool visibility,
            bool isActive, Guid categoryId,
            string seoMetaDescription, string description, double sellPrice)
        {
            if (await _productRepository.AnyAsync(x => x.Name == name))
                throw new UserFriendlyException("Tên sản phẩm đã tồn tại", Web_ECommerceDomainErrorCodes.ProductNameAlreadyExists);
            if (await _productRepository.AnyAsync(x => x.Code == code))
                throw new UserFriendlyException("Mã sản phẩm đã tồn tại", Web_ECommerceDomainErrorCodes.ProductCodeAlreadyExists);
            if (await _productRepository.AnyAsync(x => x.SKU == sKU))
                throw new UserFriendlyException("Mã SKU sản phẩm đã tồn tại", Web_ECommerceDomainErrorCodes.ProductSKUAlreadyExists);

            var category =  await _productCategoryRepository.GetAsync(categoryId);

            return new Product(Guid.NewGuid(),manufacturerId,name,code,slug,productType,sKU,sortOrder,
                visibility,isActive,categoryId,seoMetaDescription,description,null,sellPrice, category?.Name,category?.Slug);
        }
    }
}