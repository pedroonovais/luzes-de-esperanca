using Microsoft.AspNetCore.Components;

namespace web.Components.Cards
{
    public partial class HighlightCard : ComponentBase
    {
        [Parameter]
        public string Icon { get; set; }

        [Parameter]
        public required string Title { get; set; }

        [Parameter]
        public string Description { get; set; }

        [Parameter]
        public string BackgroundColor { get; set; } = " bg-background-light";
    }
}
