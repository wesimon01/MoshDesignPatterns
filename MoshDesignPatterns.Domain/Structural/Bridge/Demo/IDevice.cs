namespace MoshDesignPatterns.Domain.Structural.Bridge.Demo
{
    public interface IDevice
    {
        void TurnOn();
        void TurnOff();
        void SetChannel(int number);
    }
}
