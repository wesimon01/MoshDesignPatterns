namespace MoshDesignPatterns.Domain.Behavioral.Strategy.Demo
{
    public interface IFilter
    {
        byte[] Apply(byte[] file);
    }
}
