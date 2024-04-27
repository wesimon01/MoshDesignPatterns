namespace MoshDesignPatterns.Domain.Behavioral.Strategy.Demo
{
    public class BlackAndWhiteFilter : IFilter
    {
        public byte[] Apply(byte[] file)
        {
            Console.WriteLine("Applying BlackAndWhite Filter");
            return file;
        }
    }
}
