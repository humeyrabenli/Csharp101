using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsQuestions
{
    public class Question2
    {
        public void SecondExample()
        {
            List<int> numbers = new List<int>();

            int counter = 0;

            while (counter < 20)
            {
                Console.WriteLine($"{counter + 1}. Sayıyı Giriniz.");

                int value = int.Parse(Console.ReadLine());

                if (value <= 0)
                {
                    Console.WriteLine("Sayı Sıfırdan Küçük Olamaz.");
                    continue;
                }

                numbers.Add(value);
                counter++;

            }


            Console.WriteLine($"En Büyük 3 Sayı : {string.Join(",", numbers.OrderByDescending(x => x).Take(3))}");
            Console.WriteLine($"En Küçük 3 Sayı : {string.Join(",", numbers.OrderBy(x => x).Take(3))}");
            Console.WriteLine($"En Büyük 3 Sayının Ortalaması : {string.Join(",", numbers.OrderByDescending(x => x).Take(3).Average())}");
            Console.WriteLine($"En Küçük 3 Sayının Ortalaması : {string.Join(",", numbers.OrderBy(x => x).Take(3).Average())}");
        }
    }
}
