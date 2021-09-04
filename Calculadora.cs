using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bhaskara
{
        public class Calculadora
    {
        public double Delta { get; set; }
        public double X1 { get; set; }
        public double X2 { get; set; }

        public bool Calculo(double A, double B, double C)
        {
            Delta = (Math.Pow(B, 2) - (4 * A * C));
            X1 = ((-B + Math.Sqrt(Delta)) /( 2 * A));
            X2 = ((-B - Math.Sqrt(Delta)) /( 2 * A));

            if (Delta < 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}