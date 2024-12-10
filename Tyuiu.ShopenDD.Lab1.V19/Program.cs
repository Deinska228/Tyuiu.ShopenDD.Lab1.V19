using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.ShopenDD.Lab1.V19.Lib;

namespace Tyuiu.ShopenDD.Lab1.V19
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Лабораторная #1 | Выполнил: Шопен Д. Д. | МКМб-22-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Лабораторная #1                                                         *");
            Console.WriteLine("* Тема: Расчёты арифметических выражений в C#                             *");
            Console.WriteLine("* Вариант #19                                                             *");
            Console.WriteLine("* Выполнил: Шопен Денис Дмитриевич | МКМб-22-1                            *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу по методологии TDD на С#, которая запрашивает        *");
            Console.WriteLine("* данные с клавиатуры и вычисляет арифметическое выражение по  вариантам  *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*                             1 выражение                                 *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("*                              a                                          *");
            Console.WriteLine("*                            -----                                        *");
            Console.WriteLine("*                              y          7y - 3a                         *");
            Console.WriteLine("*                     z = ----------- + -----------                       *");
            Console.WriteLine("*                           3x - 2a       (x - 4y)                        *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("*                             2 выражение                                 *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("*                               2 * 3a         x                          *");
            Console.WriteLine("*                   z = 3y - ------------ + --------                      *");
            Console.WriteLine("*                              10x - 3a      3x + a                       *");
            Console.WriteLine("*                                           --------                      *");
            Console.WriteLine("*                                             x - 2                       *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");

            double x, y, a;

            Console.WriteLine("Введите значение X:");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение Y:");
            y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение A:");
            a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("1 выражение:");
            Console.WriteLine(ds.FirstCalculate(x, y, a));
            Console.WriteLine("2 выражение:");
            Console.WriteLine(ds.SecondCalculate(x, y, a));
            Console.ReadKey();
        }
    }
}