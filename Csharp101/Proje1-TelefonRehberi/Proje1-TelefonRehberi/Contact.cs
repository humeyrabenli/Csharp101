using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje1_TelefonRehberi
{
    class Contact
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Number { get; set; }

        public Contact(string name, string surname, string number)
        {
            this.Name = name;
            this.Surname = surname;
            this.Number = number;
        }
    }
}
