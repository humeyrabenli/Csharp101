using System;
using System.Collections.Generic;
using System.Linq;

namespace TelefonRehberi_Proje1
{

    class PhoneBook {
        private List<Person> persons {get; set;}  =new List<Person>();

        public void AddPerson(Person person)
        {
            persons.Add(person);
        }

        public void DisplayPerson(string number)
        {
            var person=persons.FirstOrDefault(p=>p.Number==number);
            if(person==null)
            {
                Console.WriteLine("Kişi Bulunamadı");
            }
            else{
                Console.WriteLine("İsim: {0}", person.Name);
                Console.WriteLine("Numara: {0}", person.Number);
            }
        }

        public void DisplayAllPerson()
        {
            foreach (var person in persons)
            {
                Console.WriteLine("İsim: {0}", person.Name);
                Console.WriteLine("Soyisim: {0}", person.Surname);
                Console.WriteLine("Numara: {0}", person.Number);
                
            }
        }

        public void DisplayMatchingPersons(string searchPhrase) 
        {
            //named: Bill
            //searchPhrase : ll
            var matchingPersons=persons.Where(p=>p.Name.Contains(searchPhrase)).ToList();
              foreach (var person in matchingPersons)
            {
                Console.WriteLine("İsim: {0}", person.Name);
                Console.WriteLine("Soyisim: {0}", person.Surname);
                Console.WriteLine("Numara: {0}", person.Number);
                
            }
        }



    }

}