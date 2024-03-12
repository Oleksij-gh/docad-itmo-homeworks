using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_10._2._1
{
    class Edge
    {
        int gradus;
        int min;
        int sec;

        public int Gradus
        {
            get{
                return gradus;
            }
            set{
                gradus = value % 360;
            }
        }
        public int Min
        {
            get
            {
                return min;
            }
            set
            {
                Gradus += value / 60;
                min = value % 60;
            }
        }
        public int Sec
        {
            get
            {
                return sec;
            }
            set
            {
                Min += value / 60;
                sec = value % 60;
            }
        }

        public Edge(int gradus, int min, int sec)
        {
            this.gradus = gradus;
            this.min = min;
            this.sec = sec;
        }

        public double ToRadians()
        {
            return Math.PI * (gradus + (min + sec / 60) / 60) / 180;
        }
    }
}
