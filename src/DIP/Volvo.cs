using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DIP
{
    public class Volvo
    {
        private readonly B20Engine _engine;

        public Volvo()
        {
            _engine = new B20Engine();
        }

        public void StartEngine()
        {
            _engine.Start();
        }


        public async Task SetSpeed(int requestedSpeed)
        {
            await _engine.AccelerateTo(requestedSpeed);
        }

        public int GetCurrentSpeed()
        {
            return _engine.CurrentSpeed;
        }
    }
}
