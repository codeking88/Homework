using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("The Area of A Rectangle");
            Console.WriteLine("What is the Length of the Rectangle?");
            int length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The length is", length);
            Console.WriteLine("What is the Width of the Rectangle?");
            int width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The Area of the Rectangle is {0}", AreaofRectangle(length, width));

        }
        static int AreaofRectangle(int length, int width)
            {
                 int result = length * width;
                 return result;
            }
    }
}