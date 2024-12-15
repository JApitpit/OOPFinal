using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPFinal.Entity;

namespace OOPFinal.Managers
{
    public class GymManager
    {
        public static GymManager INSTANCE = new GymManager();
        public List<Member> MembersList = new List<Member>();

        public List<Attendance> AttendanceList = new List<Attendance>();


    }
}
