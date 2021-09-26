using AbpDocker.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace AbpDocker.Permissions
{
    public class AbpDockerPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(AbpDockerPermissions.GroupName);
            //Define your own permissions here. Example:
            //myGroup.AddPermission(AbpDockerPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<AbpDockerResource>(name);
        }
    }
}
