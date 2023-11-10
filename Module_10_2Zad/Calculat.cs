using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_10_2Zad
{
    public interface Calculat
    {
        double PerformAddition(double a, double b);
        double PerformSubtraction(double a, double b);
        double PerformMultiplication(double a, double b);
        double PerformDivision(double a, double b);
    }
}
