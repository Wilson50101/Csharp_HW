using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW04_03
{
    delegate int Calcu(int x, int y);

    class Program
    {
        public static int add(int x, int y) { return x + y; }
        public static int sub(int x, int y) { return x - y; }
        public static int mul(int x, int y) { return x * y; }
        public static int result(int x, int y, Calcu cal) { return cal(x, y); }
        static void Main(string[] args)
        {
            int a = 10;
            int b = 3;
            int c = 2;
            int d = 5;
            //do a+b*c-d=10+3*2-5=10+6-5=16-5=11
            Console.WriteLine("do a+b*c-d=10+3*2-5");
            int r1 = result(b, c, new Calcu(mul));
            Console.WriteLine("do r1={0}*{1}={2}", b,c,r1);
            //do 10+6
            r1 = result(a, r1, new Calcu(add));
            Console.WriteLine("do r1={0}+r1={1}", a,r1);
            //do 16-5
            r1 = result(r1, d, new Calcu(sub));
            Console.WriteLine("do r1=r1-{0}={1}", d, r1);
        }
    }
}
