using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoshDesignPatterns.Domain.Adapter
{
    public interface IEmailProvider
    {
        void DownloadEmails();
    }
}
