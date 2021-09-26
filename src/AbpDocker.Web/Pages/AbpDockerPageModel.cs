using AbpDocker.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace AbpDocker.Web.Pages
{
    public abstract class AbpDockerPageModel : AbpPageModel
    {
        protected AbpDockerPageModel()
        {
            LocalizationResourceType = typeof(AbpDockerResource);
        }
    }
}