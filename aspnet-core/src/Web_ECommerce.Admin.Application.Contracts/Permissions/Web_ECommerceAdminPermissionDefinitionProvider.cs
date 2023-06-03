using Web_ECommerce.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Web_ECommerce.Admin.Permissions;

public class Web_ECommerceAdminPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        //Catalog
        var catalogGroup = context.AddGroup(Web_ECommerceAdminPermissions.CatalogGroupName, L("Permission:Catalog"));

        //Add product
        var productPermission = catalogGroup.AddPermission(Web_ECommerceAdminPermissions.Product.Default, L("Permission:Catalog.Product"));
        productPermission.AddChild(Web_ECommerceAdminPermissions.Product.Create, L("Permission:Catalog.Product.Create"));
        productPermission.AddChild(Web_ECommerceAdminPermissions.Product.Update, L("Permission:Catalog.Product.Update"));
        productPermission.AddChild(Web_ECommerceAdminPermissions.Product.Delete, L("Permission:Catalog.Product.Delete"));
        productPermission.AddChild(Web_ECommerceAdminPermissions.Product.AttributeManage, L("Permission:Catalog.Product.AttributeManage"));
        //Add attribute
        var attributePermission = catalogGroup.AddPermission(Web_ECommerceAdminPermissions.Attribute.Default, L("Permission:Catalog.Attribute"));
        attributePermission.AddChild(Web_ECommerceAdminPermissions.Attribute.Create, L("Permission:Catalog.Attribute.Create"));
        attributePermission.AddChild(Web_ECommerceAdminPermissions.Attribute.Update, L("Permission:Catalog.Attribute.Update"));
        attributePermission.AddChild(Web_ECommerceAdminPermissions.Attribute.Delete, L("Permission:Catalog.Attribute.Delete"));

        //Manufacture
        var manufacturerPermission = catalogGroup.AddPermission(Web_ECommerceAdminPermissions.Manufacturer.Default, L("Permission:Catalog.Manufacturer"));
        manufacturerPermission.AddChild(Web_ECommerceAdminPermissions.Manufacturer.Create, L("Permission:Catalog.Manufacturer.Create"));
        manufacturerPermission.AddChild(Web_ECommerceAdminPermissions.Manufacturer.Update, L("Permission:Catalog.Manufacturer.Update"));
        manufacturerPermission.AddChild(Web_ECommerceAdminPermissions.Manufacturer.Delete, L("Permission:Catalog.Manufacturer.Delete"));

        //Product Category
        var productCategoryPermission = catalogGroup.AddPermission(Web_ECommerceAdminPermissions.ProductCategory.Default, L("Permission:Catalog.ProductCategory"));
        productCategoryPermission.AddChild(Web_ECommerceAdminPermissions.ProductCategory.Create, L("Permission:Catalog.ProductCategory.Create"));
        productCategoryPermission.AddChild(Web_ECommerceAdminPermissions.ProductCategory.Update, L("Permission:Catalog.ProductCategory.Update"));
        productCategoryPermission.AddChild(Web_ECommerceAdminPermissions.ProductCategory.Delete, L("Permission:Catalog.ProductCategory.Delete"));
    }
    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<Web_ECommerceResource>(name);
    }
}