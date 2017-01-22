using System.Threading.Tasks;

namespace DIP
{
    public class BigBadV12 : IAmAnEngine
    {
        public int CurrentSpeed { get; set; }
        public bool EngineStarted { get; set; }

        public async Task AccelerateTo(int requestedSpeed)
        {
            await Task.Delay(1000);
            CurrentSpeed = requestedSpeed;
        }

        public void Start()
        {
            EngineStarted = true;
            CurrentSpeed = 0;
        }
    }
}