using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW04_02
{
    class Diamond : Shape
    {
        public double calArea(double diagonal1, double diagonal2)
        {
            return diagonal1 * diagonal2 / 2;
        }
    }
}
