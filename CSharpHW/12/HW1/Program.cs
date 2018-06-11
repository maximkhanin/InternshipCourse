using System;

namespace HW1
{
    class Program
    {
        static void Main(string[] args)
        {
            var authenticator = new Authenticator();
            while (true)
            {
                Console.WriteLine("Input Login: ");
                var login = Console.ReadLine();
                if (login == "exit")
                {
                    break;
                }

                Console.WriteLine("Input Password: ");
                var password = Console.ReadLine();
                if (password == "exit")
                {
                    break;
                }

                var user = new User(login, password);
                authenticator.AuthenticateUser(user);
            }
        }
    }
}
