using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите угол");
            int Gradus = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите минуты");
            int Min = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите секунды");
            int Sec = Convert.ToInt32(Console.ReadLine());
            angle angle = new angle(Gradus, Min, Sec);
            double radian;
            ToRadians(Gradus, Min, Sec, out radian);
            Console.WriteLine(radian);
            Console.ReadKey();
        }
        public static void ToRadians(int Gradus, int Min, int Sec, out double radian)
        {
            radian = (Math.PI / 180) * (Gradus + Min + Sec);
        }
    }
    class angle
    {
        public int Gradus;
        public int Min;
        public int Sec;
        public int gradus
        {
            set
            {
                if (value > 0 && value < 360)
                {
                    gradus = value;
                }
                else
                {
                    Console.WriteLine("Градусы указать в значении от 0 до 360");
                }
            }
        }
        public int min
        {
            set
            {
                if (value > 0)
                {
                    min = value/60;
                }
                else
                {
                    Console.WriteLine("Минуты указать в значении > 0");
                }
            }
        }
        public int sec
        {
            set
            {
                if (value > 0)
                {
                    sec = value/3600;
                }
                else
                {
                    Console.WriteLine("Секунды указать в значении > 0");
                }
            }
        }
        public angle(int gradus, int min, int sec)
        {
            Gradus = gradus;
            Min = min;
            Sec = sec;
        }
    }
}
