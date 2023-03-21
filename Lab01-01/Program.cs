using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_01
{
    internal class Program
    {
        static int Suma(int a, int b)
        {
            return a + b;
        }

        //Procedimiento que imprime la raíz cuadrada de los 10 primeros números
        static void Raiz()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("La raíz cuadrada de {0} es: {1}", i, Math.Sqrt(i));
            }

           
        }


        static int Restar(int a, int b)
        {
            return a - b;

        }
        static int Multiplicacion(int a, int b)
        {
            return a * b;

        }
        static int Division(int a, int b)
        {
            return a / b;

        }


        static void Primos()
        {
            int n = 2;
            int total = 1;

            while (total <= 10)
            {

                Boolean esPrimo = true;

                for (int i = 2; i < n; i++)
                {
                    if (n % i == 0)
                    {
                        esPrimo = false;
                        break;
                    }

                }

                if (esPrimo)
                {
                    Console.Write(" "+n);
                    total++;
                }
                n++;
            }

        }

        static void Main(string[] args)
        {
            Console.Title = "Procedimientos y funciones";
            string opcion;
            do
            {
                Console.Clear();
                Console.WriteLine("[1] Suma de dos números");
                Console.WriteLine("[2] Resta de dos números");
                Console.WriteLine("[3] Multiplicacion de dos números");
                Console.WriteLine("[4] Division de dos números");
                Console.WriteLine("[5] Imprimir la raíz cuadrada de los 10 primeros números enteros");
                Console.WriteLine("[6] Imprimir los 10 primeros números primos.");
                Console.WriteLine("[7] Celsius a Fahrenheit");
                Console.WriteLine("[8] Fahrenheit a Celsius");
                Console.WriteLine("[0] Salir");
                Console.WriteLine("Ingrese una opción y presione ENTER");
                opcion = Console.ReadLine();
                switch (opcion)
                {
                    case "1":
                        Console.WriteLine("Ingrese el primer número");
                        int a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número");
                        int b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La suma de {0} y {1} es {2}", a, b, Suma(a, b));
                        Console.ReadKey();
                        break;

                    case "2":
                        Console.WriteLine("Ingrese el primer número");
                        int c = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número");
                        int d = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La resta de {0} y {1} es {2}", c, d, Restar(c, d));
                        Console.ReadKey();
                        break;

                    case "3":
                        Console.WriteLine("Ingrese el primer número");
                        int e = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número");
                        int f = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La multiplicacion de {0} y {1} es {2}", e, f, Multiplicacion(e, f));
                        Console.ReadKey();
                        break;

                    case "4":
                        Console.WriteLine("Ingrese el primer número");
                        int g = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número");
                        int h = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La division de {0} y {1} es {2}", g, h, Division(g, h));
                        Console.ReadKey();
                        break;


                    case "5":
                        Console.WriteLine("Calculando...");
                        Raiz();
                        Console.ReadKey();
                        break;



                    case "6":
                        Console.WriteLine("Calculando...");
                        Primos();
                        Console.ReadKey();

                        break;
                    case "7":
                        int celsius, faren;
                        Console.WriteLine("Ingrese los grados Celsius(°C) : ");
                        celsius = int.Parse(Console.ReadLine());
                        faren = (celsius * 9) / 5 + 32;
                        Console.WriteLine("La temperatura en Fahrenheit es(°F) : " + faren);
                        Console.ReadLine();
                        break;

                    case "8":
                        Console.WriteLine("Ingrese los grados Fahrenheit(°F):");
                        double Fahrenheit = Convert.ToDouble(Console.ReadLine()); ;
                        double Celsius = (Fahrenheit - 32) * 5 / 9;
                        Console.WriteLine("La temperatura en Celsius(°C):" + Celsius);
                        Console.ReadLine();
                        break;


                }
            } while (!opcion.Equals("0"));


        }
    }
}
