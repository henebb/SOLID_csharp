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
}