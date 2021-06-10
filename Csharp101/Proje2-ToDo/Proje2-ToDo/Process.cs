using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje2_ToDo
{
    class Process
    {
        Board board = new Board();
        public void Menu()
        {
            Console.WriteLine("Lütfen Yapmak İstediğiniz İşlemi Seçiniz.");
            Console.WriteLine("**************************************");

            Console.WriteLine("(1) Board Listelemek");
            Console.WriteLine("(2) Board'a Kart Eklemek");
            Console.WriteLine("(3) Board'dan Kart Silmek");
            Console.WriteLine("(4) Kart Taşımak");

            
            MenuProcess(int.Parse(Console.ReadLine()));

        }

        public void MenuProcess(int processType)
        {
            var cardManager = new CardManager();
            switch (processType)
            {
                case 1:
                    cardManager.BoardList();
                    break;
                case 2:
                    cardManager.AddCard();
                    break;
                case 3:
                    cardManager.DeleteCard();
                    break;
                case 4:
                    cardManager.CarryCard();
                    
                    break;
                default: Console.WriteLine("Hatalı İşlem."); 
                    Menu(); 
                    break;
            }
        }
    }
}
