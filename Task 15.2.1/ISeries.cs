using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_15._2._1
{
    interface ISeries
    {
        
        void SetStart(int x);
        void SetStep(int s);
        int GetNext();
        void Reset();

    }
}
