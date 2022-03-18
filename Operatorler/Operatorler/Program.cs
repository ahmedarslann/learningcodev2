using System;

namespace Operatorler
{
    class Program
    {
        static void Main(string[] args)
        {
            // + - * /
            // ++ -- 
            // "ali" + "veli"
            // = -= += ...

            int sayi = 5;
            int sayi2 = 11;
            int toplam = sayi + sayi2;
            int fark = sayi - sayi2;
            int carpım = sayi * sayi2;
            int bolum = sayi2 / sayi;

            float s1 = 18;
            float s2 = 5;
            float sonuc = s1 / s2;
            //Console.WriteLine(toplam);
            //Console.WriteLine(fark);
            //Console.WriteLine(carpım);
            //Console.WriteLine(bolum);

            //Console.WriteLine("virgüllü bölüm sonucu");
            //Console.WriteLine(sonuc);
            //Console.WriteLine();

            //int yeniSayi = 1;
            //// ++ 
            //yeniSayi++;
            //++yeniSayi;
            //Console.WriteLine(yeniSayi);
            //int azaltmaSayisi = 5;
            //azaltmaSayisi--;
            //Console.WriteLine(azaltmaSayisi);
            //Console.WriteLine();

            //int sayi9 = 10;
            //sayi9 = 10;
            ////sayi9 = sayi9 + 10;
            //Console.WriteLine("sayi 9:" + sayi9);
            //Console.WriteLine();

            string a = "merhaba";
            string b = "dünya";
            string metin = a + b;
            Console.WriteLine(metin);
            Console.WriteLine();


        }
    }
}
