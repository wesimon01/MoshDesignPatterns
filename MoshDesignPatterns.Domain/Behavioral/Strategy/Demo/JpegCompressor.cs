namespace MoshDesignPatterns.Domain.Behavioral.Strategy.Demo
{
    public class JpegCompressor : ICompressor
    {
        public byte[] Compress(byte[] file)
        {
            Console.WriteLine("Compressed using Jpeg");
            return file;
        }
    }
}
