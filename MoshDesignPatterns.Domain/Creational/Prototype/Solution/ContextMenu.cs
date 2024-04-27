namespace MoshDesignPatterns.Domain.Prototype
{
    public class ContextMenu
    {
        private Timeline timeline;

        public ContextMenu(Timeline timeline)
        {
            this.timeline = timeline;
        }

        public void Duplicate(IComponent component)
        {
            var newComponent = component.Clone();
            timeline.Add(newComponent);
        }
    }
}
