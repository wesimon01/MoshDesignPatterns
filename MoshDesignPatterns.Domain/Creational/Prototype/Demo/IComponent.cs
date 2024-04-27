namespace MoshDesignPatterns.Domain.Creational.Prototype.Demo
{
    public interface IComponent
    {
        void Render();
        IComponent Clone();
    }
}
