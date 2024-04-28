namespace MoshDesignPatterns.Domain.Structural.Decorator.Demo
{
    public class CompressedCloudStream : IStream
    {
        private readonly IStream stream;

        public CompressedCloudStream(IStream stream)
        {
            this.stream = stream;
        }

        public void Write(string data)
        {
            var compressed = Compress(data);
            stream.Write(compressed);
        }

        private string Compress(string data) 
        {
            return data.Substring(0, 3);
        }
    }
}
