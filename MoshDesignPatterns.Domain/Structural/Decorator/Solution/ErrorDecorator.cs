namespace MoshDesignPatterns.Domain.Structural.Decorator.Solution
{
    public class ErrorDecorator : IArtefact
    {
        private readonly IArtefact artefact;

        public ErrorDecorator(IArtefact artefact)
        {
            this.artefact = artefact;
        }

        public string Render()
        {
            var mainIcon = artefact.Render();
            return mainIcon + " [Error]";
        }
    }
}