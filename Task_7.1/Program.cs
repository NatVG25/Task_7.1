using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_7._1
{
    class Program
    {
        static void Main(string[] args)
        {//вводим исходные параметры
            Console.WriteLine("Введите размеры сторон первого треугольника:");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите размеры сторон второго треугольника:");
            int d = Convert.ToInt32(Console.ReadLine());
            int e = Convert.ToInt32(Console.ReadLine());
            int f = Convert.ToInt32(Console.ReadLine());
            // проверяем условие возможности построения треугольника по введенным параметрам:
            // одна сторона треугольника должна быть меньше суммы 2ух остальных
            if (a < b + c && b < a + c && c < a + b && d < e + f && e < d + f && f < d + e)
            {
                double S1, S2;
                CalcSqu1(a, b, c, out S1);
                CalcSqu2(d, e, f, out S2);
                if (S1 > S2) //сравниваем полученные площади треугольников
                {
                    Console.WriteLine("площадь первого треугольника больше площади второго треугольника и равна {0,0:00}", S1);
                }
                else
                {
                    Console.WriteLine("площадь второго треугольника больше площади первого треугольника и равна {0,0:00}", S2);
                }
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Ошибка! Неверно заданы исходные данные");
                Console.ReadKey();
            }
                          
        }
        static void CalcSqu1(int a, int b, int c, out double S1) //расчет площади первого треугольника
        {
            int p1;
            p1 = (a + b + c) / 2;
            S1 = Math.Sqrt(p1 * (p1 - a) * (p1 - b) * (p1 - c));
            
        }
        static void CalcSqu2(int d, int e, int f, out double S2) //расчет площади второго треугольника
        {
            int p2;
            p2 = (d + e + f) / 2;
            S2 = Math.Sqrt(p2 * (p2 - d) * (p2 - e) * (p2 - f));
        
        }
    }
}