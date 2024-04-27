namespace MoshDesignPatterns.Domain.Behavioral.Strategy.Demo
{
    public class PngCompressor : ICompressor
    {
        public byte[] Compress(byte[] file)
        {
            Console.WriteLine("Compressed using Png");
            return file;
        }
    }
}
