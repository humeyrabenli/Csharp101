using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje2_ToDo
{
    class Card
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public int MemberID { get; set; }
        public CardSize Size { get; set; }

        public Card()
        {

        }
        public Card(string title,string content,int memberid, CardSize size)
        {
            Title = title;
            Content = content;
            MemberID = memberid;
            Size = size;
        }
    }
}
