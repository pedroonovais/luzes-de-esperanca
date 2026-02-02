using Microsoft.AspNetCore.Components;
using static System.Net.Mime.MediaTypeNames;

namespace Web.Components.Sections
{
    public partial class Projects : ComponentBase
    {
        [Inject]
        private ILogger<Projects> Logger { get; set; } = default!;

        protected IReadOnlyList<ProjectModel> ProjectsList { get; } =
            new List<ProjectModel>
            {
                new()
                {
                    Slug = "natal-solidario-2024",
                    Image = "/projetos/natal-solidario-2024/cover.jpeg",
                    Title = "Natal Solidário 2024",
                    Description = "Uma tarde de acolhimento, bem-estar e alegria aos idosos, unindo cuidado com a saúde, momentos de convivência e a entrega de carinho em forma de atenção, presentes e apoio básico.",
                    Alt = "Uma tarde de acolhimento, bem-estar e alegria aos idosos, unindo cuidado com a saúde, momentos de convivência e a entrega de carinho em forma de atenção, presentes e apoio básico."
                },
                new()
                {
                    Slug = "pequenos-economistas",
                    Image = "/projetos/pequenos-economistas/cover.jpeg",
                    Title = "Pequenos Economistas",
                    Description = "Ação social voltada à educação financeira de crianças e adolescentes, promovendo aprendizado sobre o uso consciente do dinheiro por meio de atividades lúdicas, rodas de conversa e doações para a comunidade.",
                    Alt = "Ação social voltada à educação financeira de crianças e adolescentes, promovendo aprendizado sobre o uso consciente do dinheiro por meio de atividades lúdicas, rodas de conversa e doações para a comunidade."
                },
                new()
                {
                    Slug = "natal-solidario-2025",
                    Image = "/projetos/natal-solidario-2025/cover.jpeg",
                    Title = "Natal Solidário 2025",
                    Description = "Uma tarde de acolhimento, bem-estar e alegria aos idosos, unindo cuidado com a saúde, momentos de convivência e a entrega de carinho em forma de atenção, presentes e apoio básico.",
                    Alt = "Uma tarde de acolhimento, bem-estar e alegria aos idosos, unindo cuidado com a saúde, momentos de convivência e a entrega de carinho em forma de atenção, presentes e apoio básico."
                },
            };

        protected void HandleProjectClick(string slug)
        {
            Logger.LogInformation("Projeto acessado: {Slug}", slug);
        }

        protected string GetGridClasses()
        {
            return ProjectsList.Count < 3
                ? "flex justify-center"
                : "grid grid-cols-1 sm:grid-cols-2 lg:grid-cols-3 gap-8";
        }
    }

    public sealed class ProjectModel
    {
        public string Slug { get; init; } = string.Empty;
        public string Image { get; init; } = string.Empty;
        public string Title { get; init; } = string.Empty;
        public string Description { get; init; } = string.Empty;
        public string Alt { get; init; } = string.Empty;
    }
}
