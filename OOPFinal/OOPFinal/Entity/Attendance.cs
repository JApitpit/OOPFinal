using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPFinal.Entity
{
    public class Attendance
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime SignIn { get; set; }

        public Attendance(int id, string f_name, string l_name, DateTime signIn)
        {
            Id = id;
            FirstName = f_name;
            LastName = l_name;
            SignIn = signIn;
        }
    }
}
