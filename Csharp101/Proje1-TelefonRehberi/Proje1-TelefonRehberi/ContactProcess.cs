using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje1_TelefonRehberi
{
    public class ContactProcess
    {
       
        public void Menu()
        {
            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :) ");
            Console.WriteLine(" *******************************************");
            Console.WriteLine("(1) Yeni Numara Kaydetmek");
            Console.WriteLine("(2) Varolan Numarayı Silmek");
            Console.WriteLine("(3) Varolan Numarayı Güncelleme");
            Console.WriteLine("(4) Rehberi Listelemek");
            Console.WriteLine("(5) Rehberde Arama Yapmak");

            int choice = int.Parse(Console.ReadLine());
            Process(choice);

        }

        public void Process(int choice)
        {
            var contactCrud = new ContactCRUD();
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Lütfen isim giriniz:");
                    var name = Console.ReadLine();
                    Console.WriteLine("Lütfen Soyisim Giriniz:");
                    var surname = Console.ReadLine();
                    Console.WriteLine("Lütfen telefon numarası giriniz:");
                    var number = Console.ReadLine();

                    var newContact = new Contact(name, surname, number);
                    contactCrud.AddContact(newContact);
                    break;
                case 2:
                    Console.WriteLine("Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz:");
                    string deleteName = Console.ReadLine();
                    contactCrud.DeleteContact(deleteName);
                    break;
                case 3:
                    Console.WriteLine("Lütfen numarasını güncellemek istediğiniz kişinin adını ya da soyadını giriniz:");
                    string updateName = Console.ReadLine();
                    contactCrud.UpdateContact(updateName);
                    break;
                case 4:
                    contactCrud.ListContacts();
                    break;
                case 5:
                    contactCrud.FindContact();
                    break;

                default:
                    break;
            }
        }
    }
}
