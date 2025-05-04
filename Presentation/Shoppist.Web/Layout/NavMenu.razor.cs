using Microsoft.AspNetCore.Components;

namespace Shoppist.Web.Layout;

public partial class NavMenu : ComponentBase
{
    private bool _collapseNavMenu = true;

    private string? MenuStyle => _collapseNavMenu ? "collapse" : null;

    private void ToggleNavMenu() => _collapseNavMenu = !_collapseNavMenu;
}
