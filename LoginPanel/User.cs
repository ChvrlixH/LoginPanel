using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginPanel
{
    internal class User
    {
        private string _username;
        public string Username
        {
            get
            {
                return _username;
            }
            set
            {
                restart:
                Console.Write("Istifadeci adi: ");
                string writeUsrName = Console.ReadLine();
                _username = writeUsrName;
                if (writeUsrName.Length>6)
                {
                    _username = writeUsrName;
                }
                else
                {
                    Console.WriteLine("Zehmet olmasa duzgun username teyin edin");
                    goto restart;
                }
            }
                
        }
        private string password;
        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                restartpswrd:
                Console.Write("Sifre: ");
                string writePswrd =Console.ReadLine();
                
                password = writePswrd;
                if (writePswrd != writePswrd.ToLower())
                {
                    if ( (writePswrd == "0") || (writePswrd == "1") || (writePswrd == "2") || (writePswrd == "3") || (writePswrd == "4") || (writePswrd == "5") || (writePswrd == "6") || (writePswrd == "7") || (writePswrd == "8") || (writePswrd == "9"))
                    {
                       password = writePswrd;
                    }
                }

                else
                {
                    Console.WriteLine("Zehmet olmasa duzgun sifre teyin edin");
                    goto restartpswrd;
                }
            }
        }

        public User(string username, string password)
        {
            Username = username;
            Password = password;
        }
    }


}
