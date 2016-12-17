using System.Reflection;

namespace LSP
{
    public interface IAmADuck
    {
        /// <summary>
        /// Contract says that IsSwimming should be true if Swim has been called.
        /// </summary>
        bool IsSwimming { get; }

        void Swim();

    }

    public class OrganicDuck : IAmADuck
    {
        public bool IsSwimming { get; private set; }

        public void Swim()
        {
            IsSwimming = true;
        }
    }

    public class ElectricDuck : IAmADuck
    {

        public bool IsSwimming { get; private set; }

        private bool IsTurnedOn { get; set; }

        public void Swim()
        {
            if (!IsTurnedOn)
            {
                TurnOnDuck();
            }

            IsSwimming = true;
        }

        private void TurnOnDuck()
        {
            IsTurnedOn = true;
        }
    }
}
