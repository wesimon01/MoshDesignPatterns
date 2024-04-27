namespace MoshDesignPatterns.Domain.Strategy
{
    public class AESEncryption : IEncryptionAlgorithm
    {
        public string Encrypt(string message)
        {
            Console.WriteLine("Encrypting message using AES");
            return "encryptedText";
        }
    }
}
