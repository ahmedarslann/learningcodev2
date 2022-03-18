using System;

namespace IfElseAlıstırmalar
{
    class Program
    {
        static void Main(string[] args)
        {
            ////tek çift bulan program yazınız. veri kullanıcıdan alınacak
            //Console.WriteLine("lütfen bir sayı giriniz.");
            //int sayi = Convert.ToInt32(Console.ReadLine());
            //bool ciftmi;
            //if (sayi % 2 == 0)
            //{
            //    ciftmi = true;
            //}
            //else
            //{
            //    ciftmi = false;
            //}
            //if (ciftmi == true)
            //{
            //    Console.WriteLine("sayı çifttir");

            //}
            //else
            //{
            //    Console.WriteLine("sayı tektir");

            //}
            //Console.ReadLine();

            //// lütfen bir il seçiniz: A- ankara B- istanbul C- erzurum D- trabzon E- kastamonu
            //Console.WriteLine("lütfen bir il seçiniz \n A- ankara B- istanbul C- erzurum D- trabzon E- kastamonu" );
            //string secim = Console.ReadLine();
            //if (secim == "a")
            //{
            //    Console.WriteLine("atakuleyi gezmeyi unutma.");
            //}
            //else if(secim == "b")
            //{
            //    Console.WriteLine("adalara gitmeyi unutma");

            //}
            //else if(secim == "c")
            //{
            //    Console.WriteLine("kalın giymeyi unutma");

            //}
            //else if(secim == "d")
            //{
            //    Console.WriteLine("balık yemeyi unutma");

            //}
            //else if(secim == "e")
            //{
            //    Console.WriteLine("etli ekmek yemeyi unutma");

            //}
            //Console.ReadLine();

            ////klavyeden girilen 3 sayının en küçüğünü bulma programı

            //int sayi1, sayi2, sayi3;
            //Console.WriteLine("sayi1:");
            //sayi1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("sayi2:");
            //sayi2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("sayi3:");
            //sayi3 = Convert.ToInt32(Console.ReadLine());

            //if(sayi1< sayi2 && sayi1 < sayi3)
            //{
            //    Console.WriteLine("sayi 1 en küçüktür");

            //}
            //else if(sayi2 < sayi1 && sayi2 < sayi3)
            //{
            //    Console.WriteLine("sayi 2 en küçüktür");

            //}
            //else if(sayi3 <sayi1 && sayi3 < sayi2)
            //{
            //    Console.WriteLine("sayi 3 en küçüktür");
            //}
            //Console.ReadLine();

            // 10 dan küçük sayıların tek mi çift mi olduğunu söyleyen olmayanların ise karesini söyleyen programı yazın

            Console.WriteLine("lütfen bir sayı giriniz");
            int sayi = Convert.ToInt32(Console.ReadLine());
            if (sayi <10)
            {
                if(sayi % 2 == 0)
                {
                    Console.WriteLine("sayı çifttir.");

                }
                else
                {
                    Console.WriteLine("sayi tektir.");

                }

            }
            else
            {
                Console.WriteLine("sayinin karesi:" + sayi * sayi);

            }
            Console.ReadLine();


        }
    }
}
