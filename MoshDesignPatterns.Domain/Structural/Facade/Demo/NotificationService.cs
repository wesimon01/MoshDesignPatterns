namespace MoshDesignPatterns.Domain.Structural.Facade.Demo
{
    public class NotificationService
    {
        public void Send(Message message, string target)
        {
            var server = new NotificationServer();
            var connection = server.Connect(target);
            var authToken = server.Authenticate("appId", "key");
            server.Send(authToken, message, target);
            connection.Disconnect();
        }
    }
}
