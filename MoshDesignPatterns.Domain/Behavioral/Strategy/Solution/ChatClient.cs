namespace MoshDesignPatterns.Domain.Strategy
{
    public class ChatClient
    {
        private IEncryptionAlgorithm encryptionAlgorithm;

        public ChatClient(IEncryptionAlgorithm encryptionAlgorithm)
        {
            this.encryptionAlgorithm = encryptionAlgorithm;  
        }

        public void Send(string message)
        {
            string encryptedMessage = encryptionAlgorithm.Encrypt(message);
            Console.WriteLine("Sending encrypted message...");
        }
    }
}
