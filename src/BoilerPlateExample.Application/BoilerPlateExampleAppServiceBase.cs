using Abp.Application.Services;

namespace BoilerPlateExample
{
    /// <summary>
    /// Derive your application services from this class.
    /// </summary>
    public abstract class BoilerPlateExampleAppServiceBase : ApplicationService
    {
        protected BoilerPlateExampleAppServiceBase()
        {
            LocalizationSourceName = BoilerPlateExampleConsts.LocalizationSourceName;
        }
    }
}