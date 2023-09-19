namespace MoshDesignPatterns.Domain.Structural.Bridge.Demo
{
    public class SonyTV : IDevice
    {
        private readonly string deviceName = nameof(SonyTV);
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
