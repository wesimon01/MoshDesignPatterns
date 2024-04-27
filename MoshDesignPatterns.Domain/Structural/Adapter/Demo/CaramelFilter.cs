namespace MoshDesignPatterns.Domain.Structural.Adapter.Demo
{
    //adapter
    public class CaramelFilter : IFilter
    {
        private readonly Caramel caramel;

        public CaramelFilter(Caramel caramel)
        {
            this.caramel = caramel;
        }

        public void Apply(Image image)
        {
            caramel.Init();
            caramel.Render(image);
        }
    }
}
