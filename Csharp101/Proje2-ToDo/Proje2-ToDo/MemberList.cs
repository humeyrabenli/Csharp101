using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje2_ToDo
{
    class MemberList
    {
        public static List<Member> members;

        static MemberList()
        {
            members = DefaultMembers();
        }

        public static List<Member> DefaultMembers()
        {
            return new List<Member>(){
            new Member(1,"Hümeyra Benli"),
            new Member(2,"Ayşe Yılmaz"),
            new Member(3,"Ali Özdemir"),
            new Member(4,"Tuğçe Arslan"),
            new Member(5,"Cansu Demirci"),
            };
        }
    }
}
