using System;
using System.Collections.Generic;

namespace dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int,string> kullanicilar=new Dictionary<int, string>();

            kullanicilar.Add(10,"Ayşe Yılmaz");
            kullanicilar.Add(12,"Ahmet Yılmaz");
            kullanicilar.Add(18,"Deniz Arda");
            kullanicilar.Add(20,"Özcan Coşar");

            //Dizinin elemanlarına erişim
            Console.WriteLine("----Elemanlara Erişim");
            Console.WriteLine(kullanicilar[12]);
            foreach(var item in kullanicilar)
               Console.WriteLine(item);

            //count
            Console.WriteLine("***Count***");
            Console.WriteLine(kullanicilar.Count);

            //Contains
            Console.WriteLine("***Contains***");
            Console.WriteLine(kullanicilar.ContainsKey(12));
            Console.WriteLine(kullanicilar.ContainsValue("Humeyra Benli"));

            //Remove
            Console.WriteLine("***Remove***");
            kullanicilar.Remove(12);
            foreach(var item in kullanicilar)
               Console.WriteLine(item);
            
            //Keys
            Console.WriteLine("***Keys***");
            foreach(var item in kullanicilar.Keys) 
                Console.WriteLine(item);
            //Values
            Console.WriteLine("***Values***");
            foreach (var item in kullanicilar.Values)
                Console.WriteLine(item);



        }
    }
}
