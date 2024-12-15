using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPFinal
{
    public class GymManager
    {
        public static GymManager INSTANCE = new GymManager();
        public List<Member> MembersList = new List<Member>();


    }
}
