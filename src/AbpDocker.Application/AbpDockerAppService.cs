using System;
using System.Collections.Generic;
using System.Text;
using AbpDocker.Localization;
using Volo.Abp.Application.Services;

namespace AbpDocker
{
    /* Inherit your application services from this class.
     */
    public abstract class AbpDockerAppService : ApplicationService
    {
        protected AbpDockerAppService()
        {
            LocalizationResource = typeof(AbpDockerResource);
        }
    }
}
