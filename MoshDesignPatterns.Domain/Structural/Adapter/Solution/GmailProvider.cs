namespace MoshDesignPatterns.Domain.Adapter
{
    public class GmailProvider : IEmailProvider
    {
        private readonly GmailClient gmailClient;

        public GmailProvider(GmailClient gmailClient)
        {
            this.gmailClient = gmailClient;
        }

        public void DownloadEmails()
        {
            gmailClient.Connect();
            gmailClient.GetEmails();
            gmailClient.Disconnect();
        }
    }
}
