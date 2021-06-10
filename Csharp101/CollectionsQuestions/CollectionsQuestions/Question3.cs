using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsQuestions
{
    public class Question3
    {
        public void ThirdExample()
        {
            string sentence;
            Console.WriteLine("Bir Cümle Giriniz.");
            sentence = Convert.ToString(Console.ReadLine());

            List<char> chars = new List<char>();

            foreach (char item in sentence)
            {
                if (item == 'a' || item == 'e' || item == 'i' || item == 'o' || item == 'u')
                {
                    chars.Add(item);
                }

            }

            chars.Sort();
            Console.WriteLine($"Sesli Harfler : {string.Join(",", chars.ToList())}");
        }
    }
}
