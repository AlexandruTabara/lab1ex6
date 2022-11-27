using System;

namespace lab1ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Se citesc trei numere de la tastatura, x,y,z.Scrieti un program care va afisa cele trei valori in ordin descrescatoare.
               • Exemplu: citim 3,9,0 Afisam: 9 3 0 */

            Console.WriteLine("Introduceti primul numar:");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti al doilea numar:");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti al treilea numar:");
            int z = int.Parse(Console.ReadLine());


            Console.WriteLine("Numerele in ordine descrescatoare:");
            int[] numereleMele = { x, y, z};
            Array.Reverse(numereleMele);
            foreach (int i in numereleMele)
            {
                Console.WriteLine(i);
            }
        }
    }
}
