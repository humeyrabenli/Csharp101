using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje2_ToDo
{
    class Board
    {
        
        public static List<Card> ToDo;
        public static List<Card> InProgress;
        public static List<Card> Done;

        public Board()
        {
            ToDo = DefaultToDoLineCard();
            InProgress = DefaultInProgressLineCard();
            Done = DefaultDoneCard();
        }
        public static List<Card> DefaultToDoLineCard()
        {
            return new List<Card>(){
                new Card("Başlık - A","İçerik -A",1,CardSize.S)
            };
        }
        public static List<Card> DefaultInProgressLineCard()
        {
            return new List<Card>(){
                new Card("Başlık - B","İçerik -B",2,CardSize.M)
            };
        }
        public static List<Card> DefaultDoneCard()
        {
            return new List<Card>(){
                new Card("Başlık - C","İçerik -C",3,CardSize.XL)
            };
        }



        
    
    }
}
