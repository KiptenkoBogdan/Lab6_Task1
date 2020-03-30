using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6Task1
{
    public class Square: IComparable<Square>
    {
        double side;
        double perimeter;
        public Square(double s)
        {
            this.side = s;
            this.perimeter = s * 4;
        }
        public double GetPerimeter
        {
            get
            {
                return perimeter;
            }
        }
        public int CompareTo(Square s2)
        {
            return this.perimeter.CompareTo(s2.perimeter);
        }
    }
}
