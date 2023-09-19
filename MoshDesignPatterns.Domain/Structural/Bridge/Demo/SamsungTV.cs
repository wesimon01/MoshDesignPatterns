namespace MoshDesignPatterns.Domain.Structural.Bridge.Demo
{
    public class SamsungTV : IDevice
    {
        private readonly string deviceName = nameof(SamsungTV);

        public void TurnOn()
        {
            Console.WriteLine($"{deviceName}: TurnOn");
        }

        public void TurnOff()
        {
            Console.WriteLine($"{deviceName}: TurnOff");
        }

        public void SetChannel(int number)
        {
            Console.WriteLine($"{deviceName}: SetChannel");
        }
    }
}
