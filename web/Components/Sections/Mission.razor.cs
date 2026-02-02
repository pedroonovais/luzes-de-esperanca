using Microsoft.AspNetCore.Components;

namespace web.Components.Sections;

public partial class Mission : ComponentBase
{
    protected IReadOnlyList<MissionValue> Values { get; } = new List<MissionValue>
    {
        new(
            "visibility",
            "Transparência Total",
            "Prestação de contas clara e acessível para todos os doadores. " +
            "Você sabe exatamente para onde vai sua ajuda."
        ),
        new(
            "diversity_1",
            "Tratamento Humanizado",
            "Cuidado e respeito em cada interação. Tratamos cada beneficiário " +
            "como parte da nossa família."
        ),
        new(
            "trending_up",
            "Impacto Real",
            "Projetos estruturados que trazem alegria e esperança para a comunidade."
        )
    };

    protected sealed record MissionValue(
        string Icon,
        string Title,
        string Description
    );
}
