using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppModuleTests
{
    public class Brick
    {
        private double a = 10;
        private double b = 20;
        private double c = 5;
        public void Brick_surface_area()
        {
            double S;
            S = ((a * b) + (a * c) + (c * b)) * 2;
            Console.WriteLine(S);
        }

        public double Brick_mass(double density)
        {
            double mass;
            mass = a * b * c * density;
            return mass;
        }
    }
}
