namespace MoshDesignPatterns.Domain.Structural.Decorator.Demo
{
    public class CloudStream : IStream
    {
        public void Write(string data)
        {
            Console.WriteLine($"Storing: {data}");
        }
    }
}
