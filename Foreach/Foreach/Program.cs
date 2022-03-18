using System;

namespace Foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = new int[] { 1, 2, 3, 5, 9, 10 };
            foreach (int sayi in sayilar)
            {
                Console.WriteLine(sayi);
            }
            Console.ReadLine();
        }
    }
}
