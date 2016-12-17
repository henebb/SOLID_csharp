namespace LSP
{
    public interface IAmADuck
    {
        void Swim();

        /// <summary>
        /// Contract says that IsSwimming should be true if Swim has been called.
        /// </summary>
        bool IsSwimming { get; }
    }

    public class OrganicDuck : IAmADuck
    {
        public void Swim()
        {
            IsSwimming = true;
        }

        public bool IsSwimming { get; private set; }
    }

    public class ElectricDuck : IAmADuck
    {
        public void Swim()
        {
            if (!IsTurnedOn)
            {
                return;
            }

            IsSwimming = true;
        }

        public bool IsSwimming { get; private set; }

        private bool IsTurnedOn { get; set; }
    }
}
