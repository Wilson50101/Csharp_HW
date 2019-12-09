using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW04_01
{
    class DISC
    {
        public virtual void display()
        {
            Console.WriteLine("現在播放的是光碟");
        }
    }
    class CD : DISC
    {
        public override void display()
        {
            Console.WriteLine("現在播放的是:音樂CD");
        }
    }
    class DVD : DISC
    {
        public override void display()
        {
            Console.WriteLine("現在播放的是:影片DVD");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            DISC disc = new DISC();
            CD cd = new CD();
            DVD dvd = new DVD();
            string str;
            Console.Write("請輸入放入的光碟 (CD 或 DVD) :");
            str = Console.ReadLine();
            while (str != "q" && str != "Q")
            {
                //防呆
                while (str != "CD" && str != "cd" && str != "DVD" && str != "dvd")
                {
                    Console.Write("輸入錯誤(請選擇CD 或 DVD) :");
                    str = Console.ReadLine();
                    if (str == "q" || str == "Q")
                        Environment.Exit(0);
                }
                //多型
                if (str == "CD" || str == "cd")
                    disc = cd;
                else if (str == "DVD" || str == "dvd")
                    disc = dvd;
                disc.display();

                Console.Write("請輸入放入的光碟 (CD 或 DVD) :");
                str = Console.ReadLine();
            }
        }
    }
}
