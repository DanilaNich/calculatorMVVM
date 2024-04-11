using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace кал1.Model
{
    internal class EngineeringCalculatorModel
    {
        public double SquareRoot(double number)
        {
            if (number < 0)
                throw new ArgumentException("Cannot calculate square root of a negative number.");
            return Math.Sqrt(number);
        }
        public double Sin(double angle) => Math.Sin(angle);

        public double Cos(double angle) => Math.Cos(angle);

        public double Tan(double angle) => Math.Tan(angle);

        public double Ctan(double angle) => 1 / Math.Tan(angle);

        public double Power(double number) => Math.Pow(number, 2);
    }
}
