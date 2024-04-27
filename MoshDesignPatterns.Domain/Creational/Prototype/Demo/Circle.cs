namespace MoshDesignPatterns.Domain.Creational.Prototype.Demo
{
    public class Circle : IComponent
    {
        public int Radius { get; set; }        

        public Circle()
        {
            
        }

        public void Render()
        {
            Console.WriteLine("Rendering a circle");
        }

        public IComponent Clone()
        {
            Circle circle = new();
            circle.Radius = Radius;
            return circle;
        }
    }
}
