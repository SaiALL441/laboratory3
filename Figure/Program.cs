using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figure
{
    public class Point
    {
        
        private int a;
        private int b;
        private int c;
        private int d;
        private string s;
        public int Side1 
        { get 
            { return a; 
            }
            set
            {
                a = value;
            }
        }
        public int Side2
        {
            get
            {
                return b;
            }
            set
            {
                b = value;
            }
        }
        public int Side3
        {
            get
            {
                return c;
            }
            set
            {
                c = value;
            }
        }
        public int Side4
        {
            get
            {
                return d;
            }
            set
            {
                d = value;
            }
        }
        public string Name
        {
            set 
            { s = value; }
        }
       
        public int PerimeterCalculator
        {
            get
            {
                return (a + b + c + d);
            }
        }
        public void Print()
        {
            Console.WriteLine($"{s} {a}x{b}x{c}x{d} Периметр = {PerimeterCalculator}");
        }
       
    }

    class Program
    {
        static void Main(string[] args)
        {
            Point r = new Point();
            r.Side1 = 6;
            r.Side2 = 5;
            r.Side3 = 3;
            r.Side4 = 4;
            r.Name = "ABCD";
            r.Print(); 
            
        }
    }
}
