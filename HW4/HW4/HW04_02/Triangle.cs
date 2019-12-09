using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW04_02
{
    class Triangle : Shape
    {
        public double calArea(double height,double bottom)
        {
            return height * bottom/2;
        }
    }
}
