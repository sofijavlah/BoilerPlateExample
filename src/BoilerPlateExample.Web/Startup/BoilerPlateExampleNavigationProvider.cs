using Abp.Application.Navigation;
using Abp.Localization;

namespace BoilerPlateExample.Web.Startup
{
    /// <summary>
    /// This class defines menus for the application.
    /// </summary>
    public class BoilerPlateExampleNavigationProvider : NavigationProvider
    {
        public override void SetNavigation(INavigationProviderContext context)
        {
            context.Manager.MainMenu
                .AddItem(
                    new MenuItemDefinition(
                        PageNames.Home,
                        L("HomePage"),
                        url: "",
                        icon: "fa fa-home"
                        )
                ).AddItem(
                    new MenuItemDefinition(
                        PageNames.About,
                        L("About"),
                        url: "Home/About",
                        icon: "fa fa-info"
                        )
                ).AddItem(
                    new MenuItemDefinition(
                        "Office",
                        L("Office"),
                        url: "Office",
                        icon: "fa fa-offices"
                        ).AddItem(
                        new MenuItemDefinition(
                            "Office",
                            L("Office By Id"),
                            url: "Office/GetOffice",
                            icon: "fa fa-offices"
                        )).AddItem(
                        new MenuItemDefinition(
                            "Office",
                            L("Office List"),
                            url: "Office/GetOffices",
                            icon: "fa fa-offices"
                        )).AddItem(
                        new MenuItemDefinition(
                            "Office",
                            L("Create Office"),
                            url: "Office/CreateOffice",
                            icon: "fa fa-offices"
                        ))
                    );
        }

        private static ILocalizableString L(string name)
        {
            return new LocalizableString(name, BoilerPlateExampleConsts.LocalizationSourceName);
        }
    }
}
