using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salario_mas_40_porciento
{
    class Program
    {
        static void Main(string[] args)
        {
            double sueldo, aumento;
            Console.WriteLine("Escriba sueldo");
            sueldo = int.Parse(Console.ReadLine());
            aumento = (sueldo * 0.4) + sueldo;
            Console.WriteLine("Su nuevo sueldo es: {0}", aumento);
            Console.ReadKey();

        }
    }
}
