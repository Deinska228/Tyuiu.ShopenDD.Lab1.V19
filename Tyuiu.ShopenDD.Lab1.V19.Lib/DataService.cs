using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.ShopenDD.Lab1.V19.Lib
{
    public class DataService
    {
        public double FirstCalculate(double a, double x, double y)
        {
            double res = ((a / y) / (3 * x - 2 * a)) - x + (7 * y - 3 * a) / (x - 4 * y);
            res = Math.Round(res, 2);
            return res;
        }
        public double SecondCalculate(double a, double x, double y)
        {
            double res = 3 * y + (2 * 3 * a) / (10 * x - 3 * a) + x / ((3 * x + a) / (x - 2));
            res = Math.Round(res, 2);
            return res;
        }

    }
}
