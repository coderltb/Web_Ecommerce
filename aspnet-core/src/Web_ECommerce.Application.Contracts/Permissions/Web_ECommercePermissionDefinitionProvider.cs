using Web_ECommerce.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Web_ECommerce.Permissions;

public class Web_ECommercePermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(Web_ECommercePermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(Web_ECommercePermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<Web_ECommerceResource>(name);
    }
}
