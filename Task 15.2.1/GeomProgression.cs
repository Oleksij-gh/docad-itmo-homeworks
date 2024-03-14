using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_15._2._1
{
    internal class GeomProgression : ISeries
    {

        private int progressionNow = 0;
        private int start = 0;
        private int step = 0;

        public int GetNext()
        {
            progressionNow *= step;
            return progressionNow;
        }

        public void Reset()
        {
            progressionNow = start;
        }

        public void SetStart(int x)
        {
            start = x;
            progressionNow = start;
        }

        public void SetStep(int s)
        {
            step = s;
        }
    }
}
