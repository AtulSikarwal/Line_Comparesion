Skip to content
Search or jump to…
Pull requests
Issues
Marketplace
Explore
 
@AtulSikarwal 
AtulSikarwal
/
LineComparsion
Public
Code
Issues
Pull requests
Actions
Projects
Wiki
Security
Insights
Settings
LineComparsion/LineCompersion.cs

AtulSikarwal The code of Length of Line
Latest commit 82b86c4 6 days ago
 History
 0 contributors
46 lines (40 sloc)  1.53 KB


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

       
    }
}