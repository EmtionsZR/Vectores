using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppVectorea
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Control de versiones");
            Console.WriteLine("Control de versiones1");
            Console.WriteLine("3 Elevado a la 4 es igual a: {0}", potencia(3,4));
            try {
                Console.WriteLine("-5 Elevado a la 2 es  igual a: {0}", potencia2(-5, 2));
            } catch(Exception ex)
            {
                Console.WriteLine("Error! "+ex.Message.ToString());
            }
            Console.WriteLine("2 Elevado a la 5 es  igual a: {0}", potencia2(2, 5));
            Console.ReadKey();
            }
        public static double potencia (double x, int y)
        {
            double p = 1;
            for (int i = 1; i <= y; i++) 
            {
                p = p * x;
            }
            return p;
        }
        public static double potencia2(double x, int y)
        {
            if (x <= 0)
            {
                throw new Exception("X debe ser positivo!");
            }
            if (y <= 0)
            {
                throw new Exception("Y debe ser positivo!");
            }
            double p = 1;
            for (int i = 1; i <= y; i++)
            {
                p = p * x;
            }
            return p;
        }
    }
}
