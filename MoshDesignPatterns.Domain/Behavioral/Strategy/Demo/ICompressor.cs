namespace MoshDesignPatterns.Domain.Behavioral.Strategy.Demo
{
    public interface ICompressor
    {
        byte[] Compress(byte[] file);
    }
}
