using Microsoft.AspNetCore.Components;

namespace web.Components.Sections;

public partial class Hero : ComponentBase
{
    [Parameter]
    public string Title { get; set; }

    [Parameter]
    public string Caption { get; set; }

    [Parameter]
    public required string ImagePath { get; set; }

    [Parameter]
    public string TextButton { get; set; }

    [Parameter]
    public string LinkButton { get; set; }

    protected void HandleDonationClick()
    {
        // TODO: Implementar navegação para página de doação
    }
}
