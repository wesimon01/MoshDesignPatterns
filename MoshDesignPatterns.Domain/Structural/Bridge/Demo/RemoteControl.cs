﻿namespace MoshDesignPatterns.Domain.Structural.Bridge.Demo
{
    public class RemoteControl
    {
        protected IDevice device;

        public RemoteControl(IDevice device)
        {
            this.device = device;
        }

        public void TurnOn()
        {
            device.TurnOn();
        }

        public void TurnOff()
        {
            device.TurnOff();
        }
    }
}
