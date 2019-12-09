using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW04_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape s;
            Triangle t = new Triangle();
            Rectangle r = new Rectangle();
            Diamond d = new Diamond();
            Parallelogram p = new Parallelogram();
            Console.Write("請選擇形狀(1.三角形 2.矩形 3.菱形 4.平行四邊形 0.離開):");
            int shapetype = int.Parse(Console.ReadLine());
            while (shapetype != 0)
            {
                while (shapetype > 4)
                {
                    Console.Write("輸入錯誤(1.三角形 2.矩形 3.菱形 4.平行四邊形 0.離開):");
                    shapetype = int.Parse(Console.ReadLine());
                    if (shapetype == 0)
                        Environment.Exit(0);
                }
                if (shapetype == 1)
                {
                    Console.Write("請輸入高:");
                    double height = double.Parse(Console.ReadLine());
                    Console.Write("請輸入底:");
                    double bottom = double.Parse(Console.ReadLine());
                    s = t;
                    Console.WriteLine("三角形： 高 = {0}，底 = {1}，面積為 {2}", height, bottom, s.calArea(height, bottom));

                }
                else if (shapetype == 2)
                {
                    Console.Write("請輸入長:");
                    double length = double.Parse(Console.ReadLine());
                    Console.Write("請輸入寬:");
                    double width = double.Parse(Console.ReadLine());
                    s = r;
                    Console.WriteLine("矩形： 長 = {0}，寬 = {1}，面積為 {2}", length, width, s.calArea(length, width));

                }
                else if (shapetype == 3)
                {
                    Console.Write("請輸入對角線1:");
                    double diagonal1 = double.Parse(Console.ReadLine());
                    Console.Write("請輸入對角線2:");
                    double diagonal2 = double.Parse(Console.ReadLine());
                    s = d;
                    Console.WriteLine("菱形： 對角線1 = {0}，對角線2 = {1}，面積為 {2}", diagonal1, diagonal2, s.calArea(diagonal1, diagonal2));

                }
                else //if (shapetype == 4)
                {
                    Console.Write("請輸入高:");
                    double height = double.Parse(Console.ReadLine());
                    Console.Write("請輸入底:");
                    double bottom = double.Parse(Console.ReadLine());
                    s = p;
                    Console.WriteLine("平行四邊形： 高 = {0}，底 = {1}，面積為 {2}", height, bottom, s.calArea(height, bottom));

                }
                Console.Write("請選擇形狀(1.三角形 2.矩形 3.菱形 4.平行四邊形 0.離開):");
                shapetype = int.Parse(Console.ReadLine());
            }
        }
    }
}
