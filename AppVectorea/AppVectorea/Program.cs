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
            Console.WriteLine("\n\tRafael Scatizzi\n********************************\n");
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
            vectorinicial();
            VectorClases();
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
        public static void vectorinicial()
        {
            int[] x = new int[8];
            x[0] = 10;
            x[1] = 2;
            x[2] = 20;
            x[3] = 8;
            x[4] = 15;
            x[5] = 1;
            x[6] = -9;
            x[7] = 14;
            //imprimir el vector
            Console.WriteLine("\n\tElementos del Vector\n====================================\n");
            for(int i=0;i<8;i++)
            {
                Console.WriteLine("Elemento indice {0} --> {1}", (i + 1), x[i]);
            }
            //suma de los elementos vector
            int s = 0;
            Console.WriteLine("\n\tElementos del Vector\n===================================\n");
            for (int i = 0; i < x.Length; i++)
            {
                s = s + x[i];
            }
            Console.WriteLine("La sumatoria es: {0}",s);
            Console.WriteLine("El promedio es: {0}", s/x.Length);
        }
        public static void VectorClases()
        {
            int[] x = new int[10];
            int z = 0;
            if (z >= 1 && z <= 1000)
                for(int i=0;i<x.Length;i++)
                Console.Write("\nIngrese un numero: ");
                z = int.Parse(Console.ReadLine());
        }
    }
}
