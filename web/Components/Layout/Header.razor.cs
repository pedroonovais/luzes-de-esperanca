
using Microsoft.AspNetCore.Components;

namespace web.Components.Layout;

public partial class Header : ComponentBase
{
    protected bool IsMobileMenuOpen { get; private set; }

    protected void ToggleMobileMenu()
    {
        IsMobileMenuOpen = !IsMobileMenuOpen;
    }

    protected void CloseMobileMenu()
    {
        IsMobileMenuOpen = false;
    }
}
