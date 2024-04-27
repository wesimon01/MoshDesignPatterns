namespace MoshDesignPatterns.Domain.Strategy
{
    public interface IEncryptionAlgorithm
    {
        string Encrypt(string message);
    }
}
