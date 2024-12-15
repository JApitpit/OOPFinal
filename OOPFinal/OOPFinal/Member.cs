using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPFinal
{
    public class Member
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }
        public DateOnly JoinDate { get; set; }
        public string? Status { get; set; }

        public Member(int id, string f_name, string l_name, string phone,  string email, DateOnly joinDate, string status)
        {
            Id = id;
            FirstName = f_name;
            LastName = l_name;
            Phone = phone;
            Email = email;
            JoinDate = joinDate;
            Status = status;
        }
    }
}

