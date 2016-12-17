namespace LSP
{
    public class ElectricDuck : IAmADuck
    {

        public bool IsSwimming { get; private set; }

        private bool IsTurnedOn { get; set; }

        public void Swim()
        {
            if (!IsTurnedOn)
            {
                return;
            }

            IsSwimming = true;
        }
    }
}
