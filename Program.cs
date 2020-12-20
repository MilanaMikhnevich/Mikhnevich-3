using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mikhnevich_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите коэффициенты квадратного уранения (a*x^2 + b*x + c = 0):");
            Console.Write("a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("b: ");
            double c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Решение уравнения: {solver(a, b, c)}"); 
            Console.ReadKey();
        }

        static string solver(double a, double b, double c)
        {
            double discriminant = b * b - 4 * a * c;
            if (a == 0)
                return "это не квадратное уравнение.";
            if (discriminant < 0)
                return "нет корней";
            else if (discriminant == 0)
                return (-b / 2 / a).ToString();
            else
                return  ((-b - Math.Sqrt(discriminant)) / 2 / a).ToString() + " ; " +
                        ((-b + Math.Sqrt(discriminant)) / 2 / a).ToString();
        }
    }
}
