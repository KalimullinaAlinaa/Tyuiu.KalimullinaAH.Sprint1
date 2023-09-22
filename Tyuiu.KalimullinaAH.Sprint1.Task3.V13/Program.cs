using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KalimullinaAH.Sprint1.Task3.V13.Lib;
namespace Tyuiu.KalimullinaAH.Sprint1.Task3.V13
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнила: Калимуллина А.Х | ИИПБ-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #13                                                             *");
            Console.WriteLine("* Выполнила: Калимуллина Алина Халимовна | ИИПБ-23-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу , которая запрашивает у пользователя исходные данные *");
            Console.WriteLine("* выполняет указанные расчёты  и печатает результат на экране.           *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            double x = 123;

            Console.WriteLine("Трёхзначное число = "+ x);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("***************************************************************************");


            Console.WriteLine("Произведение цифр трёхзначного числа: "+ ds.Calculate(x ));
            Console.ReadKey();
        }
    }
}
