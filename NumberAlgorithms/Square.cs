using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberAlgorithms
{
    public class Square
    {
        public double Sqrt(double n, double p)
        {
            double l = 1, h = n, m = 0;

            while(h - l > p)
            {
                m = l + (h - l) / 2;
                if (m * m - n > p)
                    h = m;
                else
                    l = m;
            }

            return h;
        }
    }
}
