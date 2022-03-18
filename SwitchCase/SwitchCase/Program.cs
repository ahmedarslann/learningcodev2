using System;

namespace SwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi = 3;
            switch (sayi)
            {
                case 1:
                    Console.WriteLine("sayi 1 dir");
                    break;
                case 2:
                    Console.WriteLine("sayi 2 dir");
                    //goto case 4;
                    break;
                case 4:
                    Console.WriteLine("sayi 4 dür");
                    break;
                default:
                    Console.WriteLine("sayi 1 yada 2 değildir");
                    break;
            }
            Console.ReadLine();
        }
    }
}
