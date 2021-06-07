using System;

namespace TelefonRehberi_Proje1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz");
            Console.WriteLine("************************");
            Console.WriteLine("(1) Yeni numara kaydetmek");
            Console.WriteLine("(2) Varolan numarayı silmek");
            Console.WriteLine("(3) Varolan numarayı güncelleme");
            Console.WriteLine("(4) Rehberi listelemek");
            Console.WriteLine("(5) Rehberde Arama Yapmak");

            var userInput=Console.ReadLine();

            var phoneBook=new PhoneBook();

            switch(userInput)
            {
                case "1":
                    Console.WriteLine("Lütfen isim giriniz:");
                    var name=Console.ReadLine();
                    Console.WriteLine("Lütfen soyisim giriniz:");
                    var surname=Console.ReadLine();
                    Console.WriteLine("Lütfen numara giriniz:");
                    var number=Console.ReadLine();

                    var newPerson=new Person(name,surname,number);
                    phoneBook.AddPerson(newPerson);
                    break;

                case "2":
                break;

                case "3":
                break;

                case "4":
                break;

                case "5":
                break;
                
                default:
                    Console.WriteLine("Lütfen geçerli bir işlem giriniz");
                    break;

            }
        }
    }
}
