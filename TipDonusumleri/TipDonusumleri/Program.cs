using System;

namespace TipDonusumleri
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi = 5;
            long buyukSayi = 9;
            // -2,147,483,648 - 2,147,483,648
            // -9,223,372,036,854,775,808 - 9,223,372,036,854,775,808
            long sayi3 = sayi;
            int sayi5 = (int)buyukSayi;


            //string
            string a = "3";
            string b = "9";
            //Convert
            int toplam = Convert.ToInt32(a) + Convert.ToInt32(b);
            Console.WriteLine(a + b);
            Console.WriteLine(toplam);
            Console.WriteLine();
        }
    }
}
