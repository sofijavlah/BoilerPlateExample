﻿using Abp.Application.Navigation;
using Abp.Localization;
using BoilerPlateExample.Models;

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
                            L("By Id"),
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
                            L("Create"),
                            url: "Office/CreateOffice",
                            icon: "fa fa-offices"
                        ))
                ).AddItem(
                    new MenuItemDefinition(
                        "Employee",
                        L("Employee"),
                        url: "Employee",
                        icon: "fa fa-employees"
                    ).AddItem(
                        new MenuItemDefinition(
                            "Employee",
                            L("By Id"),
                            url: "Employee/GetEmployee",
                            icon: "fa fa-employees"
                        )).AddItem(
                        new MenuItemDefinition(
                            "Employee",
                            L("Employee List"),
                            url: "Employee/GetEmployees",
                            icon: "fa fa-employees"
                        )).AddItem(
                        new MenuItemDefinition(
                            "Employee",
                            L("Create"),
                            url: "Employee/CreateEmployee",
                            icon: "fa fa-employees"
                        ))).AddItem(
                    new MenuItemDefinition(
                        "Device",
                        L("Device"),
                        url: "Device",
                        icon: "fa fa-devices"
                    ).AddItem(
                        new MenuItemDefinition(
                            "Device",
                            L("By Id"),
                            url: "Device/GetDevice",
                            icon: "fa fa-facebook"
                        )).AddItem(
                        new MenuItemDefinition(
                            "Device",
                            L("Device List"),
                            url: "Device/GetDevices",
                            icon: "fa fa-devices"
                        )).AddItem(
                        new MenuItemDefinition(
                            "Device",
                            L("Create"),
                            url: "Device/CreateDevice",
                            icon: "fa fa-devices"
                        )));
        }

        private static ILocalizableString L(string name)
        {
            return new LocalizableString(name, BoilerPlateExampleConsts.LocalizationSourceName);
        }
    }
}
