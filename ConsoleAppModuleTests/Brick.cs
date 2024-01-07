using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppModuleTests
{
    public class Brick
    {
        public double Brick_surface_area(double height, double width, double length)
        {
            if (height <= 0 || width <= 0 || length <= 0)
            { throw new ArgumentException("The entered values are not greater than zero"); }
            double S;
            S = ((height * width) + (width * length) + (height * length)) * 2;
            return S;
        }

    }
}
