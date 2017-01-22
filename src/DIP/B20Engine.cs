using System.Threading;
using System.Threading.Tasks;

namespace DIP
{
    public class B20Engine
    {
        public bool EngineStarted { get; set; }
        public int CurrentSpeed { get; set; }

        public void Start()
        {
            EngineStarted = true;
            CurrentSpeed = 0;
        }

        public async Task AccelerateTo(int requestedSpeed)
        {
            await Task.Delay(17000);

            CurrentSpeed = requestedSpeed;
        }
    }
}