namespace MoshDesignPatterns.Domain.Strategy
{
    public class DESEncryption : IEncryptionAlgorithm
    {
        public string Encrypt(string message)
        {
            Console.WriteLine("Encrypting message using DES");
            return "encryptedText";
        }
    }
}
