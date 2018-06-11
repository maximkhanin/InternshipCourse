using System;
using System.Net.Mail;

namespace HW1
{
    interface IUser
    {
        string Name { get; set; }
        string Password { get; set; }
        MailAddress Email { get; set; }
        DateTime Time { get; set; }
        string GetFullInfo();
    }
}
