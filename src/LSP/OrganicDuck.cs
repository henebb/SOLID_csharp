namespace LSP
{
    public class OrganicDuck : IAmADuck
    {
        public bool IsSwimming { get; private set; }

        public void Swim()
        {
            IsSwimming = true;
        }
    }
}