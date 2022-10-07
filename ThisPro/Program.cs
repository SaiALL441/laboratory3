using System;
using System.Net;
using System.Security;
using System.Threading;

namespace ThisPro
{
    public class Rectangle
    {
        private double a; //поле side 1
        private double b; //поле side 2
       

        public double SideA //проверка стороны 1
        {
            get { return a; }
            set
            {
                if (value > 0)
                    a = value;
                else
                    Console.WriteLine("Ошибка А == 0");
            }
        }

        public double SideB //проверка стороны 2, чтобы не минус
        {
            get { return b; }
            set
            {

                if (value > 0)
                    b = value;
                else
                    Console.WriteLine("Ошибка В == 0");
            }
        }


        public double AreaCalculator
        {
            get
            {
                return a*b;
            }
        }
        public double PerimeterCalculator
        {
            get
            {
                return (a + b)*2;
            }
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle();
            string F;
            double w, h;
            Console.WriteLine("X need: ");
            F = Console.ReadLine();
            w = Convert.ToDouble(F);

            Console.WriteLine("Y need: ");
            F = Console.ReadLine();
            h = Convert.ToDouble(F);

            rect.SideA = w;
            rect.SideB = h;
            Console.WriteLine(w * h);
            Console.WriteLine((w+h)*2);
            Console.ReadLine();


        }
    }
    

}
