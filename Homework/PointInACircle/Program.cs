using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointInACircle
{
    class Program
    {
        static void Main(string[] args)
        {
            double xCenter = 0.0;
            double yCenter = 0.0;
            double r = 2.0;
            Console.WriteLine("Please input x and y values");
            Console.Write("x = ");
            double xCenterP = Convert.ToDouble(Console.ReadLine());
            Console.Write("y = ");
            double yCenterP = Convert.ToDouble(Console.ReadLine());
            bool inside;
            inside = ((xCenterP - xCenter) * (xCenterP - xCenter) + (yCenterP - yCenter) * (yCenterP - yCenter)) <= (r * r);
            Console.WriteLine(inside);
        }
    }
}
