using System;

namespace AlgoritmaSorulari
{
    class Program
    {
        static void Main(string[] args)
        {

            

        }

        static void FirstExample()
        {
            Console.WriteLine("Lütfen pozitif bir sayı giriniz(n)");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[n];

            if (n < 0)
            {
                Console.WriteLine("Lütfen pozitif bir sayı giriniz!");
            }

            else
            {

                Console.WriteLine("Girdiğiniz n sayısı kadar sayı giriniz:");
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine("{0}. sayıyı giriniz", i + 1);
                    array[i] = Convert.ToInt32(Console.ReadLine());
                }

                foreach (var number in array)
                {
                    if (number % 2 == 0)
                    {
                        Console.WriteLine("{0} bir çift sayıdır", number);
                    }
                }
            }
        }

        static void SecondExample()
        {
            Console.WriteLine("Lütfen pozitif iki sayı giriniz (n ve m)");
            Console.WriteLine("n sayısını giriniz:");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("m sayısını giriniz:");
            int m = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Girdiğiniz n sayısı kadar sayı giriniz:");
            int[] array2 = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}. sayıyı giriniz", i + 1);
                array2[i] = Convert.ToInt32(Console.ReadLine());
            }

            foreach (var number in array2)
            {
                if (number == m || number % m == 0)
                {
                    Console.WriteLine("Sonuc: " + number);
                }

            }
        }

        static void ThirdExample()
        {
            Console.WriteLine("Pozitif bir sayı girin (n):");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Girdiğiniz n sayısı kadar kelime giriniz:");
            string[] words = new string[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}. kelime:", i + 1);
                words[i] = Console.ReadLine();
            }

            Array.Reverse(words);
            foreach (var word in words)
            {
                Console.WriteLine(word);
            }
        }

        static void FourthExample()
        {
            Console.WriteLine("Lütfen bir cümle giriniz:");
            string sentence = Convert.ToString(Console.ReadLine());

            int lettersCount = sentence.Replace(" ", string.Empty).Length;
            int wordCount = sentence.Split(' ').Length;
            Console.WriteLine("Kelime sayısı : " + wordCount.ToString());
            Console.WriteLine("Harf Sayısı : " + lettersCount.ToString());
        }


    }
}
