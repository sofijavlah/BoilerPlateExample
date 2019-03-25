using Abp.AspNetCore.Mvc.Views;

namespace BoilerPlateExample.Web.Views
{
    public abstract class BoilerPlateExampleRazorPage<TModel> : AbpRazorPage<TModel>
    {
        protected BoilerPlateExampleRazorPage()
        {
            LocalizationSourceName = BoilerPlateExampleConsts.LocalizationSourceName;
        }
    }
}
