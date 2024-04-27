namespace MoshDesignPatterns.Domain.Behavioral.Strategy.Demo
{
    public class ImageStorage
    {
        private readonly ICompressor compressor;
        private readonly IFilter filter;

        public ImageStorage(ICompressor compressor, IFilter filter)
        {
            this.compressor = compressor;
            this.filter = filter;
        }

        public void Store(byte[] file)
        {
            var compressedFile = compressor.Compress(file);
            var filteredFile = filter.Apply(compressedFile);
        }
    }
}
