namespace MoshDesignPatterns.Domain.Adapter
{
    public class EmailClient
    {
        private List<IEmailProvider> providers = new();

        public void AddProvider(IEmailProvider provider)
        {
            providers.Add(provider);
        }

        public void DownloadEmails()
        {
            foreach (var provider in providers)
                provider.DownloadEmails();
        }
    }
}
