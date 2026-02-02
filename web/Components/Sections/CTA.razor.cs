using Microsoft.AspNetCore.Components;

namespace Web.Components.Sections
{
    public partial class Cta : ComponentBase
    {
        private readonly ILogger<Cta> _logger;

        public Cta(ILogger<Cta> logger)
        {
            _logger = logger;
        }

        protected void HandleDonateClick()
        {
        }

        protected void HandleVolunteerClick()
        {
        }
    }
}
