namespace MoshDesignPatterns.Domain.Structural.Decorator.Solution
{
    public class MainDecorator : IArtefact
    {
        private readonly IArtefact artefact;

        public MainDecorator(IArtefact artefact)
        {
            this.artefact = artefact;
        }

        public string Render()
        {
            return artefact.Render() + " [Main]";
        }
    }
}