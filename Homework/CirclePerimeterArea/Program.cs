using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CirclePerimeterArea
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Radius value:");
            double radius = double.Parse(Console.ReadLine());
            double perimeter = 2 * Math.PI * radius;
            double area = Math.PI * (radius * radius);
            Console.WriteLine("Radius : {0} , Perimeter : {1:F2} , Area : {2:F2} .", radius, perimeter, area);
        }
    }
}
