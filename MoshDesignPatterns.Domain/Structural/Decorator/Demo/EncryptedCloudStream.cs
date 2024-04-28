namespace MoshDesignPatterns.Domain.Structural.Decorator.Demo
{
    public class EncryptedCloudStream : IStream
    {
        private readonly IStream stream;

        public EncryptedCloudStream(IStream stream)
        {
            this.stream = stream;
        }

        public void Write(string data)
        {
            var encryptedData = Encrypt(data);
            stream.Write(encryptedData);
        }

        private string Encrypt(string data)
        {
            return "!@#%$#^@#$%!@#$";
        }
    }
}
