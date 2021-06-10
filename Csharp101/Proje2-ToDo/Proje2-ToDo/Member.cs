using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje2_ToDo
{
    class Member
    {
        public int Id { get; set; }
        public string MemberName { get; set; }

        public Member(int id, string membername)
        {
            Id = id;
            MemberName = membername;
        }
      
      
    }
}
