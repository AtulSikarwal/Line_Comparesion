

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineCompersion
{
    internal class LineCompersion
    {
        public double Line()
        {
            Console.WriteLine("Enter the Value for X1");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Value for X2");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Value for Y1");
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Value for Y2");
            int y2 = Convert.ToInt32(Console.ReadLine());
            double result = Math.Sqrt((x2 - x1) ^ 2 + (y2 - y1) ^ 2);
            Console.WriteLine(result);
            return result;


        }

        public double LineTwo()
        {
            Console.WriteLine("Enter the Coodinates of line Two");
            Console.WriteLine("Enter the Value for X1");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Value for X2");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Value for Y1");
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Value for Y2");
            int y2 = Convert.ToInt32(Console.ReadLine());
            double result2 = Math.Sqrt((x2 - x1) ^ 2 + (y2 - y1) ^ 2);
            Console.WriteLine(result2);
            return result2;


        }
    }
}