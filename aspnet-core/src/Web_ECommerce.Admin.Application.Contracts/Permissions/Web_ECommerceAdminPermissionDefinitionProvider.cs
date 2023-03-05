using Web_ECommerce.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Web_ECommerce.Admin.Permissions;

public class Web_ECommerceAdminPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(Web_ECommerceAdminPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(Web_ECommercePermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<Web_ECommerceResource>(name);
    }
}
