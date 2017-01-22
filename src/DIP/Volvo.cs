using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DIP
{
    public class Volvo
    {
        private readonly IAmAnEngine _engine;

        public Volvo(IAmAnEngine engine)
        {
            _engine = engine;
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
