namespace MoshDesignPatterns.Domain.Structural.Adapter.Demo
{
    //adaptee
    public class Caramel // class from 3rd party lib
    {
        public void Init()
        {
        }

        public void Render(Image image)
        {
            Console.WriteLine("Applying caramel filter");
        }
    }
}
