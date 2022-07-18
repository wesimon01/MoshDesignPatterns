using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
