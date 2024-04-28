namespace MoshDesignPatterns.Domain.Structural.Decorator.Solution
{
    public class Artefact : IArtefact
    {
        private readonly string name;

        public Artefact(string name)
        {
            this.name = name;
        }

        public string Render()
        {
            return this.name;
        }
    }
}