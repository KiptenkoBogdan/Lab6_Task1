using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6Task1
{
    class Program
    {
        static void Main()
        {
            Square s1 = new Square(5);
            Square s2 = new Square(2);
            Square s3 = new Square(5);

            Console.WriteLine("\tSquare perimeters");
            Console.WriteLine("s1 = {0}", s1.GetPerimeter);
            Console.WriteLine("s2 = {0}", s2.GetPerimeter);
            Console.WriteLine("s3 = {0}\n", s3.GetPerimeter);

            if (s1.CompareTo(s2) == 1)
            {
                Console.WriteLine("s1 > s2");
            }
            else if(s1.CompareTo(s2) == 0)
            {
                Console.WriteLine("s1 = s2");
            }
            else
            {
                Console.WriteLine("s1 < s2");
            }

            if (s1.CompareTo(s3) == 1)
            {
                Console.WriteLine("s1 > s3");
            }
            else if (s1.CompareTo(s3) == 0)
            {
                Console.WriteLine("s1 = s3");
            }
            else
            {
                Console.WriteLine("s1 < s3");
            }

            Console.ReadKey();
        }
    }
}
