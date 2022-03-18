using System;

namespace ForDongusu
{
    class Program
    {
        static void Main(string[] args)
        {
            //başlangıç - koşul - arrtırma yada azaltma işlemleri
            // for (int i = 1; i <= 10 ; i++)
            //{
            // Console.writeLine(i);
            //}

            //1-x arasındaki sayıları ekrana yazdırın. x kullanıcıdan alınacak.
            //Console.WriteLine("lütfen bir sayi giriniz");
            //int sayi = Convert.ToInt32(Console.ReadLine());

            //for (int i =1; i <= sayi; i++)
            //{
            //    Console.WriteLine(i);
            //}
            ////soru 2 = 100 - 1 arasındaki sayıları yazınız
            //for(int i =1000; i >= 1; i--)
            //{
            //    Console.WriteLine(i);
            //}

            //soru 3 = 1 ile 1000 arasında 3 e bölünen sayıları yazdırınız.

            //for (int i = 1; i < 1000; i++)

            //{
            //    if(i % 3 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }

            //}
            //1 ile 1000 arasında 5e bölünen 11. sayı 
            int sayac = 0;
            for (int i = 1; i < 1000; i++)
            {
                if(i % 5 == 0)
                    {
                    sayac++;
                    if(sayac== 11)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
