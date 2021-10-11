using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_HeronsFormula
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Ввод данных
            Console.WriteLine("Введите первую сторону первого треугольника");
            double a1Side = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите вторую сторону первого треугольника");
            double b1Side = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите третью сторону первого треугольника");
            double c1Side = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите первую сторону второго треугольника");
            double a2Side = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите вторую сторону второго треугольника");
            double b2Side = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите третью сторону второго треугольника");
            double c2Side = Convert.ToDouble(Console.ReadLine());
            #endregion

            double area1Triangle = Heron(a1Side, b1Side, c1Side);
            double area2Triangle = Heron(a2Side, b2Side, c2Side);

            if (area1Triangle>area2Triangle)
            {
                Console.WriteLine("Площадь первого треугольника больше площади второго {0:f2} > {1:f2}",area1Triangle,area2Triangle);
            }
            else
            {
                Console.WriteLine("Площадь первого треугольника меньше площади второго {0:f2} < {1:f2}", area1Triangle, area2Triangle);
            }
            Console.ReadKey();
        }
        static double Heron (double a, double b, double c)
        {
            double perimeterHalf = (a + b + c) / 2;
            double area = Math.Sqrt(perimeterHalf*(perimeterHalf-a)*(perimeterHalf-b)*(perimeterHalf-c));
            return area;
        }
    }
}
