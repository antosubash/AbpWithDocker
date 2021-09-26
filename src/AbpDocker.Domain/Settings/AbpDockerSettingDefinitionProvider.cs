using Volo.Abp.Settings;

namespace AbpDocker.Settings
{
    public class AbpDockerSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(AbpDockerSettings.MySetting1));
        }
    }
}
