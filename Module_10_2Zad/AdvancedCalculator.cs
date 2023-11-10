using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_10_2Zad
{
    public class AdvancedCalculator : SimpleCalculator, IStorable
    {
        // Методы для арифметических операций уже реализованы в базовом классе SimpleCalculator

        public double Power(double baseValue, double exponent)
        {
            double result = Math.Pow(baseValue, exponent);
            Console.WriteLine($"Результат: {result}");
            return result;
        }

        public double SquareRoot(double value)
        {
            if (value < 0)
            {
                Console.WriteLine("Не удается вычислить квадратный корень из отрицательного числа.");
                return 0;
            }

            double result = Math.Sqrt(value);
            Console.WriteLine($"Результат: {result}");
            return result;
        }

        // Реализация методов интерфейса IStorable
        public void SaveToFile(string fileName)
        {
            // Реализация сохранения состояния в файл
            Console.WriteLine($"Сохранен состояния калькулятора в {fileName}");
        }

        public void LoadFromFile(string fileName)
        {
            // Реализация загрузки состояния из файла
            Console.WriteLine($"Загрузка в {fileName}");
        }
    }
}