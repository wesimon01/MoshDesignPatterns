using MoshDesignPatterns.Domain.State;

namespace MoshDesignPatterns.Domain
{
    public class DirectionService
    {
        private ITravelMode travelMode;

        public DirectionService(ITravelMode travelMode)
        {
            this.travelMode = travelMode;
        }

        public object GetEta()
        {
            return travelMode.GetEta();    
        }

        public object GetDirection()
        {
            return travelMode.GetDirection();
        }
    }
}