using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.KalimullinaAH.Sprint1.Task3.V13.Lib
{
    public class DataService : ISprint1Task1V13
    {
        public double Calculate(double x)
        {
            string numberStr = x.ToString();
            int n1 = int.Parse(numberStr[0].ToString()); // Первая цифра
            int n2 = int.Parse(numberStr[1].ToString()); // Вторая цифра
            int n3 = int.Parse(numberStr[2].ToString()); // Третья цифра

            int p = n1 * n2 * n3;
            return p;
        }
    }
}
