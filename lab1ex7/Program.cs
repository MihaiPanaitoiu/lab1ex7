using System;

namespace lab1ex7
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Ex7
                 Scrieti un program care va verifica daca un numar citit de la tastatura este par sau
                 impar
                  In cazul in care numarul este par, programul va afisa “par” iar in caz contrar, “impar”.
                  Google :even and odd number
             */

            Console.WriteLine("Acest program va afisa daca numarul este par sau impar");

            Console.WriteLine("Introduceti numarul");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(num % 2 == 0 ? "par" : "impar");

        }
    }
}
