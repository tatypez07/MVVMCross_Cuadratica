using System;

namespace Factorial.Core.Services
{
    public class FactorialService : IFactorialService
    {
        public double GetFactorial(int n)
        {
            if (n <= 1)
            {
                return 1;
            }

            return n * GetFactorial(n - 1);
        }

        public double CuadraticoP(double a, double b, double c)
        {
           
            return (-b + (Math.Sqrt(b * b - (4 * a * c)))) / (2 * a);
        }

        public double CuadraticoN(double a, double b, double c)
        {
            return (-b - (Math.Sqrt(b * b - (4 * a * c)))) / (2 * a);
        }
    }
}
