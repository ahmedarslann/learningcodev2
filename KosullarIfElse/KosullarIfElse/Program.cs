using System;

namespace KosullarIfElse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("lütfen bir sayıyı giriniz : ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            if (sayi > 10)
            {
                Console.WriteLine("sayı 10 dan büyüktür");

            }
            else
            {
                Console.WriteLine("sayı 10 dan küçüktür veya eşittir");
            }
            Console.ReadLine();
        }
    }
}
