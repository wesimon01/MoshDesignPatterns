﻿namespace MoshDesignPatterns.Domain.Structural.Facade.Demo
{
    public class NotificationServer
    {
        public Connection Connect(string ipAddress)
        {
            return new Connection();
        }

        public AuthToken Authenticate(string appId, string key)
        {
            return new AuthToken();
        }

        public void Send(AuthToken authToken, Message message, string target)
        {
            Console.WriteLine("Sending a message");
        }        
    }
}
