using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LSP
{
    public class DuckContest
    {
        public IList<IAmADuck> Ducks { get; private set; }

        public DuckContest()
        {
            Ducks = new List<IAmADuck>();
        }

        public void AddDuck(IAmADuck duck)
        {
            Ducks.Add(duck);
        }

        public void StartContest()
        {
            foreach (var duck in Ducks)
            {
                MakeDuckSwim(duck);
            }
        }

        private void MakeDuckSwim(IAmADuck duck)
        {
            duck.Swim();
        }
    }
}
