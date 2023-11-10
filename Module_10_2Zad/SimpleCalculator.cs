using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_10_2Zad
{
    public class SimpleCalculator : Calculat
    {
        public double PerformAddition(double a, double b)
        {
            double result = a + b;
            Console.WriteLine($"Результат: {result}");
            return result;
        }

        public double PerformSubtraction(double a, double b)
        {
            double result = a - b;
            Console.WriteLine($"Результат: {result}");
            return result;
        }

        public double PerformMultiplication(double a, double b)
        {
            double result = a * b;
            Console.WriteLine($"Результат: {result}");
            return result;
        }

        public double PerformDivision(double a, double b)
        {
            if (b == 0)
            {
                Console.WriteLine("Не может делить на ноль.");
                return 0;
            }

            double result = a / b;
            Console.WriteLine($"Результат: {result}");
            return result;
        }
    }
}
