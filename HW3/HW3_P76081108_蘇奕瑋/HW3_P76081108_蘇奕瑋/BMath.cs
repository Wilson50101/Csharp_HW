using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3_P76081108_蘇奕瑋
{
    class BMath:AMath
    {
        public double Avg(int []a, int size)
        {
            int sum = 0;
            for (int i = 0; i < a.Length; i++)
                sum += a[i];
            return (double)sum / size;
        }
    }
}
