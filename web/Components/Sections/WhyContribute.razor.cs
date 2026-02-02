using Microsoft.AspNetCore.Components;

namespace Web.Components.Sections
{
    public partial class WhyContribute : ComponentBase
    {
        protected IReadOnlyList<ContributionReason> Reasons { get; } =
            new List<ContributionReason>
            {
                new(
                    "groups",
                    "Fortalecimento Comunitário",
                    "Contribuições direcionadas ajudam a construir uma rede de apoio sólida na comunidade, criando um ambiente mais acolhedor e colaborativo."
                ),
                new(
                    "verified",
                    "Uso Responsável dos Recursos",
                    "Planejamento e acompanhamento constante garantem que cada recurso seja aplicado de forma eficiente e transparente."
                ),
                new(
                    "timeline",
                    "Transformação Sustentável",
                    "Promovendo mudanças estruturais que beneficiam a comunidade de forma permanente."
                ),
                new(
                    "handshake",
                    "Participação Ativa",
                    "Ao contribuir, você participa de uma iniciativa coletiva onde cada ação soma."
                )
            };
    }

    public sealed record ContributionReason(
        string Icon,
        string Title,
        string Description
    );
}
