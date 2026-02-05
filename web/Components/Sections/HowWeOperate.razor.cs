using Microsoft.AspNetCore.Components;

namespace Web.Components.Sections
{
    public partial class HowWeOperate : ComponentBase
    {

        protected IReadOnlyList<Values> ListValues { get; } = new List<Values>
        {
            new(
                "location_on",
                "Região de Atuação",
                "Atuamos principalmente na região de Barueri, desenvolvendo projetos que atendem diretamente às necessidades da comunidade local."
            ),
            new(
                "volunteer_activism",
                "Trabalho Voluntário",
                "Nossa organização é composta exclusivamente por voluntários dedicados, que doam tempo e energia para tornar nossos projetos realidade."
            ),
            new(
                "groups",
                "Projetos Estruturados",
                "Desenvolvemos ações planejadas e organizadas, com foco em resultados concretos e impacto positivo na vida das pessoas."
            ),
            new(
                "handshake",
                "Parcerias Estratégicas",
                "Trabalhamos em conjunto com outras organizações e instituições para ampliar nosso alcance e impacto na comunidade."
            ),
        };

        protected sealed record Values(
            string Icon,
            string Title,
            string Description
        );
    }
}
