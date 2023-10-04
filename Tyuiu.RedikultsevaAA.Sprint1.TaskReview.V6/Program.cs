using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Написать программу, которая вычисляет математическое
// выражение по исходным значениям данных, вводимых пользователем. Ответ округлите до 3 знаков после запятой.
// z = (1 + 1/x^2) ^x - 12x^2y  

using Tyuiu.RedikultsevaAA.Sprint1.TaskReview.V6.Lib;

namespace Tyuiu.RedikultsevaAA.Sprint1.TaskReview.V6
{
    class Program
    {
        static void Main(string[] args)
        {

            DataService ds = new DataService();
            Console.Title = "SprintReview | Выполнила: Редикульцева А.А. | АСОиУб 23-1";
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* SprintReview                                                               *");
            Console.WriteLine("* Вариант #6                                                                 *");
            Console.WriteLine("* Выполнила: Редикульцева А.А. | АСОиУб 23-1                                 *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                   *");
            Console.WriteLine("* Написать программу, которая вычисляет математическое выражение по исходным *");
            Console.WriteLine("* значениям данных, вводимых пользователем.                                  *");
            Console.WriteLine("* Ответ округлите до 3 знаков после запятой.                                 *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                           *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("                 x ");
            Console.WriteLine("    (      1    )          2 ");
            Console.WriteLine("z = ( 1 + ----  ) - 12 * x   * y ");
            Console.WriteLine("    (       2   ) ");
            Console.WriteLine("    (      x    ) ");


            double x, y;

            Console.WriteLine("Введите значение X:");
            x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение Y:");
            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                 *");
            Console.WriteLine("******************************************************************************");

            Console.WriteLine(ds.Calculate(x, y));

            Console.ReadKey();
        }
    }
}
