using System;

namespace TelefonRehberi_Proje1
{
    class Person
    {
       public string Name {get; set;}

       public string Surname{get; set;}
       public string Number{get; set;}

       public Person(string name,string surname,string number)
       {
           this.Name=name;
           this.Surname=surname;
           this.Number=number;

       }
    }
}