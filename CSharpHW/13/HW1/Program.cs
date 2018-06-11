using System;

namespace HW1
{
    class Program
    {
        static void Main(string[] args)
        {
            var authenticator = new Authenticator();
            var userDataBase = new UserDataBase();
            while (true)
            {
                Console.WriteLine("Input Login: ");
                var login = Console.ReadLine();
                if (login == "exit")
                {
                    userDataBase.Dispose();
                    break;
                }

                Console.WriteLine("Input Password: ");
                var password = Console.ReadLine();
                if (password == "exit")
                {
                    userDataBase.Dispose();
                    break;
                }

                var user = new User(login, password);

                authenticator.AuthenticateUser(user, userDataBase);
            }
        }
    }
}
