using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje1_TelefonRehberi
{
    class ContactCRUD
    {
        ContactProcess cp = new ContactProcess();
        
        
        //Kişi ekleme işlemi
        public void AddContact(Contact contact)
        {
            ContactList.contacts.Add(contact);
            Console.WriteLine("Kişi başarıyla eklendi");
            cp.Menu();
        }

        //Kişi silme işlemi
        public void DeleteContact(string nameorsurname)
        {
            Contact result= ContactList.contacts
                .FirstOrDefault(x => x.Name.ToLower() == nameorsurname.ToLower() || x.Surname.ToLower() == nameorsurname.ToLower());

            if (result == null)
            {
                Console.WriteLine("Aradığınız krtiterlere uygun kişi rehberde bulunamadı. Lütfen bir seçim yapınız.");
                Console.WriteLine("* Anasayfaya Dön : (1)");
                Console.WriteLine("* Yeniden denemek için : (2)");

                int value = int.Parse(Console.ReadLine());

                if (value == 1)
                    cp.Menu();
                else if (value == 2)
                    DeleteContact(nameorsurname);

            }

            else
            {
                Console.WriteLine($"{result.Name} {result.Surname} İsimli Kişi Rehberden Silinmek Üzere.Onaylıyor musunuz? (y/n)");
                string confirmDelete = Console.ReadLine();

                if (confirmDelete == "y")
                {

                    foreach (var person in ContactList.contacts)
                    {
                        if (person == result) 
                        {
                            ContactList.contacts.Remove(person);
                            Console.WriteLine("Silme işlemi başarıyla tamamlandı.");
                            cp.Menu();
                            break;
                        }
                    }
                    
                }
                else if (confirmDelete == "n")
                {
                    Console.WriteLine("Silme İşlemi İptal Edildi.");
                    cp.Menu();
                }
            }
        }

        //Kişi güncelleme işlemi
        public void UpdateContact(string nameorsurname)
        {
            Contact result = ContactList.contacts
                .FirstOrDefault(x => x.Name.ToLower() == nameorsurname.ToLower() || x.Surname.ToLower() == nameorsurname.ToLower());

            if (result == null)
            {
                Console.WriteLine("Aradığınız krtiterlere uygun kişi rehberde bulunamadı. Lütfen bir seçim yapınız.");
                Console.WriteLine("* Anasayfaya Dön : (1)");
                Console.WriteLine("* Yeniden denemek için : (2)");

                int value = int.Parse(Console.ReadLine());

                if (value == 1)
                    cp.Menu();
                else if (value == 2)
                    UpdateContact(nameorsurname);

            }

            else
            {
                Console.WriteLine("Güncellenecek Telefon Numarasını Giriniz:");
                string newPhoneNumber = Console.ReadLine();
                result.Number = newPhoneNumber;
                Console.WriteLine("Telefon Numarası Güncellendi.");
                var persons = ContactList.contacts;
                cp.Menu();
            }
        }

        //Kişileri listeleme işlemi
        public void ListContacts()
        {
            var contacts = ContactList.contacts.ToList();

            Console.WriteLine("A-Z Listele (1)");
            Console.WriteLine("Z-A Listele (2)");

            int input = int.Parse(Console.ReadLine());

            Console.WriteLine("*****************************************");
            if (input == 1)
            {
                foreach (var person in contacts.OrderBy(x => x.Name))
                {
                    Console.WriteLine("İsim " + person.Name);
                    Console.WriteLine("Soyisim " + person.Surname);
                    Console.WriteLine("Telefon " + person.Number);
                    Console.WriteLine("-");
                }
                cp.Menu();
            }

            else if (input == 2)
            {
                foreach (var person in contacts.OrderByDescending(x => x.Name))
                {
                    Console.WriteLine("İsim " + person.Name);
                    Console.WriteLine("Soyisim " + person.Surname);
                    Console.WriteLine("Telefon " + person.Number);
                    Console.WriteLine("-");
                }
                cp.Menu();
            }
        }


        //Kişi bulma işlemi
        public void FindContact()
        {
            Console.WriteLine("Arama yapmak istediğiniz tipi seçiniz.");
            Console.WriteLine("**********************************************");
            Console.WriteLine(" İsim veya soyisime göre arama yapmak için: (1)");
            Console.WriteLine(" Telefon numarasına göre arama yapmak için: (2)");

            int input = int.Parse(Console.ReadLine());

            if (input == 1)
            {
                Console.WriteLine("Arama Yapacağınız İsmi veya Soyisimi Giriniz : ");
                var result = FindContactsByName(Console.ReadLine());

                foreach (var person in result)
                {
                    Console.WriteLine("İsim : " + person.Name);
                    Console.WriteLine("Soyisim : " + person.Surname);
                    Console.WriteLine("Telefon : " + person.Number);
                }
            }

            else if (input == 2)
            {
                Console.WriteLine("Arama Yapacağınız Telefon Numarasını Giriniz : ");
                var result = FindContactsByNumber(Console.ReadLine());

                foreach (var person in result)
                {
                    Console.WriteLine("İsim : " + person.Name);
                    Console.WriteLine("Soyisim : " + person.Surname);
                    Console.WriteLine("Telefon : " + person.Number);
                }
            }

            cp.Menu();
        }

        //İsme göre kişi bulma
        public List<Contact> FindContactsByName(string nameOrLastname)
        {
            return ContactList.contacts.Where(x => x.Name.ToLower() == nameOrLastname.ToLower() || x.Surname.ToLower() == nameOrLastname.ToLower()).ToList();
        }


        //Numaraya göre kişi bulma
        public List<Contact> FindContactsByNumber(string number)
        {
            return ContactList.contacts.Where(x => x.Number == number).ToList();
        }

    }
}
