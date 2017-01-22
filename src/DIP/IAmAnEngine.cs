using System.Threading.Tasks;

namespace DIP
{
    public interface IAmAnEngine
    {
        int CurrentSpeed { get; set; }
        bool EngineStarted { get; set; }

        Task AccelerateTo(int requestedSpeed);
        void Start();
    }
}