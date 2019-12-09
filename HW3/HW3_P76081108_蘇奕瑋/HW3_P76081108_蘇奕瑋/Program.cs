using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3_P76081108_蘇奕瑋
{
    class Program
    {
        static void Main(string[] args)
        {
            BMath Average = new BMath();
            int n1 = 20, n2 = 25;
            Console.WriteLine("({0}+{1})/2={2}", n1, n2, Average.Avg(n1, n2));
            int[] n = { 10, 12, 36, 44, 55 };
            Console.WriteLine("Average of array={0}", Average.Avg(n, 5));
            Console.Read();
        }
    }
}
