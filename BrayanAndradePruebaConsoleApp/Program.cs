using System;
using System.Threading;


namespace BrayanAndradePruebaConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread departamento1 = new Thread(MetodoPersonas);
            Console.WriteLine("en este departamento hay");
            departamento1.Start();
            Thread departamento2 = new Thread(MetodoPersonas);
            Console.WriteLine("en este departamento hay");
            departamento2.Start();
            Thread departamento3 = new Thread(MetodoPersonas);
            departamento3.Start();
            Thread departamento4 = new Thread(MetodoPersonas);
            Console.WriteLine("en este departamento hay");
            departamento4.Start();
            Thread departamento5 = new Thread(MetodoPersonas);
            Console.WriteLine("en este departamento hay");
            departamento5.Start();
            Thread departamento6 = new Thread(MetodoPersonas);
            Console.WriteLine("en este departamento hay");
            departamento6.Start();
        }

        private static void MetodoPersonas(object obj)
        {
            string persona1, persona2, persona3, persona4, persona5, persona6;
            byte A;
            Console.Write("En este piso vive la persona: "); persona1 = Console.ReadLine();
            Console.Write("En este piso vive la persona: "); persona2 = Console.ReadLine();
            Console.Write("En este piso vive la persona: "); persona3 = Console.ReadLine();
            Console.Write("En este piso vive la persona: "); persona4 = Console.ReadLine();
            Console.Write("En este piso vive la persona: "); persona5 = Console.ReadLine();
            Console.Write("En este piso vive la persona:"); persona6 = Console.ReadLine();
            for (A = 1; A <= 6; A++);
            {
                var azar = new Random();
                Console.Write(" " + persona1);
                System.Threading.Thread.Sleep(azar.Next(1, 6));
                Console.Write(" " + persona2);
                System.Threading.Thread.Sleep(azar.Next(1, 6));
                Console.Write(" " + persona3);
                System.Threading.Thread.Sleep(azar.Next(1, 6));
                Console.Write(" " + persona4);
                System.Threading.Thread.Sleep(azar.Next(1, 6));
                Console.Write(" " + persona5);
                System.Threading.Thread.Sleep(azar.Next(1, 6));
                Console.Write(" " + persona6);
                System.Threading.Thread.Sleep(azar.Next(1, 6));
            }       
        }
    }
}
