using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    internal class Circle
    {
        public double radius { get; set; }

        public Circle()
        {

        }

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public double Area()
        {
            return radius * 3.14 * radius;
        }

        public double Perimeter()
        {
            return radius * 2 * 3.14;
        }

    }
}
