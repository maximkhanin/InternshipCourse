using System;
using System.Net.Mail;
using System.Text.RegularExpressions;

namespace HW1
{
    class User: IUser
    {  
        public string Name { get;  set; }
        public string Password { get;  set; }
        public MailAddress Email { get;  set; }
        public DateTime Time { get; set; } 

        public User(string login, string password)
        {
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");

            if (string.IsNullOrWhiteSpace(login))
            {
                throw new NullReferenceException("Login Is Null or WhiteSpace");
            }
            
            if (regex.IsMatch(login))
            {
                Email = new MailAddress(login);
            }
            else
            {
                Name = login;    
            }
            Password = password;
        }

        public string GetFullInfo()
        {
            return (Name + " " + Password + " " + Email);
        }
    }
}
