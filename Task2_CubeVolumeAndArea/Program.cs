using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_CubeVolumeAndArea
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Внесите значение длины ребра куба:");
            double sideCube = Convert.ToDouble(Console.ReadLine());

            double areaCube = 0.00;
            double volumeCube = 0.00;

            CubeCalcs(sideCube, out areaCube, out volumeCube);
            Console.WriteLine("Площадь всех поверхностей куба составляет {0:f2}, а объём куба {1:f2}", areaCube,volumeCube);
            Console.ReadKey();
        }
        static void CubeCalcs (double a, out double S, out double V)
        {
            S = a * a * 6;
            V = Math.Pow(a, 3.00);
        }
    }
}
