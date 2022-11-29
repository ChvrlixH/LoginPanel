using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginPanel
{
    internal class Admin:User
    {
        public bool IsSuperAdmin;
        public string Section;

        public Admin(bool issuperadmin, string section, string username, string password) : base(username, password)
        {
            IsSuperAdmin = issuperadmin;
            Section = section;
        }

        public void UsersInfo()
        {
            Console.WriteLine("");
            Console.WriteLine("Database_Users:");
            Console.WriteLine($"IsSuperAdmin: {IsSuperAdmin}; Section: {Section}; Username: {Username}; Password: {Password}");
        }
    }
}
