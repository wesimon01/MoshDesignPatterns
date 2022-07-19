using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoshDesignPatterns.Domain.Adapter
{
    public class GmailProvider : IEmailProvider
    {
        private GmailClient gmailClient = new GmailClient();

        public void DownloadEmails()
        {
            gmailClient.Connect();
            gmailClient.GetEmails();
            gmailClient.Disconnect();
        }
    }
}
