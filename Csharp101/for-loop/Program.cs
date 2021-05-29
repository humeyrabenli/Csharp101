using System;

namespace for_loop
{
    class Program
    {
        static void Main(string[] args)
        {
           /*  Console.Write("lütfen bir sayı giriniz:");
            int sayac=int.Parse(Console.ReadLine());
            for (int i = 1; i<=sayac; i++)
            {
                if (i%2==1)
                {
                    Console.WriteLine(i);
                }
                
            } */
            //1 ile 100 arasındaki tek ve çift sayıların kendi içlerindeki toplamlarını ekrana yazdır
           /*  int tekToplam=0;
            int ciftToplam=0;

            for (int i = 0; i <= 1000; i++)
            {
                if (i%2==1)
                {
                    tekToplam +=i;

                }
                else
                {
                    ciftToplam +=i;

                }
                
            }
            Console.WriteLine("Tek toplam: "+tekToplam);
            Console.WriteLine("Çift toplam:" +ciftToplam); */

            //break, continue
            for (int i = 1; i < 10; i++)
            {
                if(i==4)
                  break;
                Console.WriteLine(i);    
            }

            for (int i = 1; i < 10; i++)
            {
                if(i==4)
                  continue;
                Console.WriteLine(i);    
            }
        }
    }
}
