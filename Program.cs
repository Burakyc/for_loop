# for_loop
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ekrandan Girilen sayıya kadar olan tek sayılarını ekrana yazdır.
           /* Console.Write("Lütfen bir sayı giriniz: ");
            int sayac = int. Parse(Console. ReadLine());
            for (int i = 1; i <= sayac; i++){
                if (i%2 == 1)
            Console.WriteLine(i);

            }
            
            //1 ile 1000 arasindaki tek ve cift sayilarin kendi iclerinde toplamlarını ekrana yazdir.
            int tekToplam = 0;
            int ciftToplam = 0;
            for (int i = 1; i <= 1000; i++)
            {
            if(i%2 == 1)
            tekToplam += 1; // texToplam = tektoplan . 1;
            else
            ciftToplam += 1; // texToplam = tekToplam + 4;
            }

            Console.WriteLine("Tek Toplam: " + tekToplam);
            Console.WriteLine( "Cift Toplam: " +tekToplam);*/

            // break, continue
            for (int i = 1; i < 10; i++){
                 if(i==4)
                break;
                Console.WriteLine(1);
            }


            for (int i = 1; i < 10; i++){
            if (i==4)
            continue;
            Console.WriteLine(i);
             }


        }
    }
}
