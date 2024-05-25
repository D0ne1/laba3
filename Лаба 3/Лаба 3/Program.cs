using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаба_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x = Math.PI/5; // координаты первой проверяемой точки
            double b = 9*Math.PI/5; // координаты последней проверяемой точки
            double e = 0.0001;
            double k = 10;
            double y; // переменная для счёта значения функции
            double elementse; // элемент Se, который буде проверяться на точность е
            double se = 0; // сумма элементов в Se
            double sn = 0; // сумма элементов в Sn
            int j = 0; // счётчик для вычисления Se (имеет то же значение, что и n для Sn)
            double xk = (b - x) / k; // шаг, на который будем прибавлять х, проверяя 10 точек на промежутке
            for (int i = 1; i <= k; i++)
            {
                y = -Math.Log(Math.Abs(2 * Math.Sin(x / 2)));
                sn = 0;
                se = 0;
                j = 0;
                for (int n = 1; n < 40; n++)
                {
                    sn += (Math.Cos(n * x)) / n;
                }
                do
                {
                    j += 1;
                    elementse = (Math.Cos(j * x) / j);
                    se += elementse;
                } while (Math.Abs(elementse) > e);
                Console.WriteLine($"{i}) X = {x}; Y = {y}; Sn = {sn}; Se = {se}");
                x += xk;
            }
        }
    }
}