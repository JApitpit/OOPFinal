using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPFinal.Platforms
{
    public class DBManager
    {
        
        private GymManager gymManager;
        public static DBManager INSTANCE { get; private set; } = new DBManager();
        public List<Member> MembersList { get; private set; } = new List<Member>();


        private DBManager()
        {
            gymManager = GymManager.INSTANCE;
        }

        public async Task InitializeAsync()
        {
            await LoadMembers();

        }

        public async Task RefreshCustomerAsync()
        {
            await LoadMembers();
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
    }
}
