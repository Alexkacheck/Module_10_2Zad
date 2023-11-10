using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_10_2Zad
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Calculat simpleCalculator = new SimpleCalculator();
            Calculat advancedCalculator = new AdvancedCalculator();

            Console.WriteLine("Простой калькулятор:");
            simpleCalculator.PerformAddition(5, 3);
            simpleCalculator.PerformSubtraction(7, 2);
            simpleCalculator.PerformMultiplication(4, 6);
            simpleCalculator.PerformDivision(10, 2);

           
            Console.WriteLine("\nКрутой калькулятор:");
            advancedCalculator.PerformAddition(5, 2);
            ((AdvancedCalculator)advancedCalculator).Power(7, 3); // Приводим к типу AdvancedCalculator
            ((AdvancedCalculator)advancedCalculator).SquareRoot(65); // Приводим к типу AdvancedCalculator
            ((IStorable)advancedCalculator).SaveToFile("C:/Users/RepublikONE/source/repos/Module_10_2Zad/Calculator/calculator.txt"); 
            ((IStorable)advancedCalculator).LoadFromFile("C:/Users/RepublikONE/source/repos/Module_10_2Zad/Calculator/calculator.txt"); 
        }
    }
}
