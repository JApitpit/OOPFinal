using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPFinal.Entity;

namespace OOPFinal.Managers
{
    public class DBManager
    {

        private GymManager gymManager;
        public static DBManager INSTANCE { get; private set; } = new DBManager();
        public List<Member> MembersList { get; private set; } = new List<Member>();
        public List<Attendance> AttendanceList { get; private set; } = new List<Attendance>();


        private DBManager()
        {
            gymManager = GymManager.INSTANCE;
        }

        public async Task InitializeAsync()
        {
            await LoadMembers();
            await LoadAttendance();

        }

        public async Task RefreshCustomerAsync()
        {
            await LoadMembers();
            await LoadAttendance();
        }

        public async Task LoadMembers()
        {

            string relativePath = "Resources/Raw/members.csv";

            string memberFile = Path.Combine(AppContext.BaseDirectory, relativePath);


            if (!File.Exists(memberFile))
                throw new FileNotFoundException($"The file '{memberFile}' was not found.");

            using var stream = new FileStream(memberFile, FileMode.Open, FileAccess.Read);
            using var reader = new StreamReader(stream);


            string? line = reader.ReadLine();
            if (line == null) throw new Exception("File is empty.");

            MembersList.Clear();
            while ((line = reader.ReadLine()) != null)
            {
                var values = line.Split(',');

                MembersList.Add(new Member(
                    int.Parse(values[0]),
                    values[1],
                    values[2],
                    values[3],
                    values[4],
                    DateOnly.Parse(values[5]),
                    values[6]
                ));
            }
        }

        //public void CreateAttendance(Member member, DateTime signIn)
        //{
        //    var attendance = new Attendance(member, signIn);
        //    SaveAttendance(attendance);

        //}
        public void SaveAttendance(Attendance attendance)
        {

            string relativePath = "Resources/Raw/attendance.csv";

            string attendanceFile = Path.Combine(AppContext.BaseDirectory, relativePath);

            string csvLine = $"{attendance.Id},{attendance.FirstName},{attendance.LastName}," +
                            $"{attendance.SignIn}";

            using (var writer = new StreamWriter(attendanceFile, true))
            {
                writer.WriteLine(csvLine);
            }

        }
        public async Task LoadAttendance()
        {
            {

                string relativePath = "Resources/Raw/attendance.csv";

                string attendanceFile = Path.Combine(AppContext.BaseDirectory, relativePath);


                if (!File.Exists(attendanceFile))
                    throw new FileNotFoundException($"The file '{attendanceFile}' was not found.");

                using var stream = new FileStream(attendanceFile, FileMode.Open, FileAccess.Read);
                using var reader = new StreamReader(stream);


                string? line = reader.ReadLine();
                if (line == null) throw new Exception("File is empty.");

                AttendanceList.Clear();
                while ((line = reader.ReadLine()) != null)
                {
                    var values = line.Split(',');

                    AttendanceList.Add(new Attendance(
                        int.Parse(values[0]),
                        values[1],
                        values[2],
                        DateTime.Parse(values[3])
                    ));
                }
            }
        }
    }
}
