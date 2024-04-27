namespace MoshDesignPatterns.Domain.Prototype
{
    public class Timeline
    {
        private List<IComponent> components = new List<IComponent>();
        
        public void Add(IComponent component)
        {
            components.Add(component);  
        }
    }
}
