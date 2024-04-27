namespace MoshDesignPatterns.Domain.Creational.Prototype.Demo
{
    public class ContextMenu
    {


        public void Duplicate(IComponent component)
        {
            var cloned = component.Clone();
        }
    }
}
