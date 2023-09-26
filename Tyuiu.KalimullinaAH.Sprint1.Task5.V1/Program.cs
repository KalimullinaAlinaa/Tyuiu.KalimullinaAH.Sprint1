using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KalimullinaAH.Sprint1.Task5.V1.Lib;
namespace Tyuiu.KalimullinaAH.Sprint1.Task5.V1
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
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #12                                                             *");
            Console.WriteLine("* Выполнила: Калимуллина Алина Халимовна | ИИПБ-23-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу , которая решает следующую задачу:                   *");
            Console.WriteLine("* Найти расстояние между двумя точками с заданными координатами x,y       *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Введите координату х1");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координату х2");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координату у1");
            double y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координату у2");
            double y2 = Convert.ToDouble(Console.ReadLine());

            var res = ds.DistanceBetweenDots(x1,y1,x2,y2);
            var result = Convert.ToInt32(res);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Расстояние междy точками = " + (res));

            Console.ReadKey();
        }
    }
}
