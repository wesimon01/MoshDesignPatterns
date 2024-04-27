namespace MoshDesignPatterns.Domain.Behavioral.Strategy.Demo
{
    public class HighContrast : IFilter
    {
        public byte[] Apply(byte[] file)
        {
            Console.WriteLine("Applying HighConstrast Filter");
            return file;
        }
    }
}
