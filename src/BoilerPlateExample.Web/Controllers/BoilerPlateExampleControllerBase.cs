using Abp.AspNetCore.Mvc.Controllers;

namespace BoilerPlateExample.Web.Controllers
{
    public abstract class BoilerPlateExampleControllerBase: AbpController
    {
        protected BoilerPlateExampleControllerBase()
        {
            LocalizationSourceName = BoilerPlateExampleConsts.LocalizationSourceName;
        }
    }
}