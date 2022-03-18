using System;

namespace SwitchOrnekler
{
    class Program
    {
        static void Main(string[] args)
        {
            //// kulanıcıdan haftanın gününü alıp hava tahmini gösteren program yazınız.
            //string gun = Console.ReadLine();
            //switch (gun)
            //{
            //    case "pazartesi":
            //        Console.WriteLine("0 derece");
            //        break;
            //    case "salı":
            //        Console.WriteLine("1 derece");
            //        break;
            //    case "carsamba":
            //        Console.WriteLine("2 derece");
            //        break;
            //    case "persembe":
            //        Console.WriteLine("3 derece");
            //        break;
            //    case "cuma":
            //        Console.WriteLine("4 derece");
            //        break;
            //    default:
            //        Console.WriteLine("bugun için tahmin bir tahmin yoktur.");
            //        break;


            //}
            //Console.ReadLine();


            //switch case ile bir hesap makinası yapınız
            //kullanıcıdan 2 sayı alınacak
            //işlem sourlacak ve sonuç gösterilecek

            int sayi1, sayi2;
            Console.WriteLine("sayı 1 giriniz");
            sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("sayı 2 yi giriniz");
            sayi2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("lütfen işlem işaretini seçiniz + - * /");
            string islem = Console.ReadLine();

            switch(islem)
            {
                case "+":
                    Console.WriteLine(sayi1 + sayi2);
                    break;
                case "-":
                    Console.WriteLine(sayi1 - sayi2);
                    break;
                case "*":
                    Console.WriteLine(sayi1 * sayi2);
                    break;
                case "/":
                    Console.WriteLine(sayi1 / sayi2);
                    break;
                default:
                    Console.WriteLine("lütfen belirtilen işlemleri giriniz");
                    break;

            }
            Console.ReadLine();
        }
    }
}
