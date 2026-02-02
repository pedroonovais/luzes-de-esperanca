using Microsoft.AspNetCore.Components;

namespace web.Components.Sections;

public partial class HeroSection : ComponentBase
{
    protected string HeroBackgroundStyle =>
        "background-image: " +
        "linear-gradient(to top, rgba(0, 0, 0, 0.7) 0%, " +
        "rgba(0, 0, 0, 0.2) 60%, rgba(0,0,0,0) 100%), " +
        "url('/cover-hero-section.jpeg');";

    protected void HandleDonationClick()
    {
        // TODO: Implementar navegação para página de doação
    }
}
