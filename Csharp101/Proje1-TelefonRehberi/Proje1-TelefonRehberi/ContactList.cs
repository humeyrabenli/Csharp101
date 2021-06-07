using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje1_TelefonRehberi
{
    class ContactList
    {
        public static List<Contact> contacts;

        static ContactList()
        {
            contacts = DefaultContacts();
        }


        //Rehberde default olarak bulunan 5 kişi
        public static List<Contact> DefaultContacts()
        {
            return new List<Contact>()
            {
                new Contact("Hümeyra","Benli","0124568"),
                new Contact("Ayşe","Yılmaz","1458752"),
                new Contact("Ali", "Işık", "0145876"),
                new Contact("Elif", "Demir", "3254789"),
                new Contact("Nehir", "Arslan", "1547869")
            };   
        }
    }
}
