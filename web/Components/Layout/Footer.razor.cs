using Microsoft.AspNetCore.Components;

namespace Web.Components.Layout
{
    public partial class Footer : ComponentBase
    {
        protected int CurrentYear { get; } = DateTime.UtcNow.Year;
    }
}
