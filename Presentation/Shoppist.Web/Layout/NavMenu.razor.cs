using Microsoft.AspNetCore.Components;

namespace Shoppist.Web.Layout;

public partial class NavMenu : ComponentBase
{
    private readonly NavMenuItem[] _menuItems =
    [
        new NavMenuItem("Home", "/"),
        new NavMenuItem("Items", "/items")
    ];
    private bool _collapseNavMenu = true;
    private string? MenuStyle => _collapseNavMenu ? "collapse" : null;

    private void ToggleNavMenu() => _collapseNavMenu = !_collapseNavMenu;
}

internal record NavMenuItem(string Title, string Url);