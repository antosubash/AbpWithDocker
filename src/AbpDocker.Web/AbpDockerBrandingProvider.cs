using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace AbpDocker.Web
{
    [Dependency(ReplaceServices = true)]
    public class AbpDockerBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "AbpDocker";
    }
}
