using System;
using System.Collections.Generic;

namespace HW1
{
    class Authenticator : IAuthenticator
    {
        private readonly List<IUser> _userDataBase;

        public Authenticator()
        {
            _userDataBase = new List<IUser>();
        }

        public void AuthenticateUser(IUser user)
        {
            LoginCheck(user);
        }

        private void LoginCheck(IUser user)
        {
            if (string.IsNullOrEmpty(user.Name))
            {
                foreach (var item in _userDataBase)
                {
                    if (item.Email.Address == user.Email.Address)
                    {
                        if (item.Password == user.Password)
                        {
                            Console.WriteLine(item.Time);
                            item.Time = DateTime.Now;
                            return;
                        }

                        Console.WriteLine("Password is incorrect");
                        return;
                    }
                }
            }
            else
            {
                foreach (var item in _userDataBase)
                {
                    if (item.Name == user.Name)
                    {
                        if (item.Password == user.Password)
                        {
                            Console.WriteLine(item.Time);
                            item.Time = DateTime.Now;
                            return;
                        }

                        Console.WriteLine("Password is incorrect");
                        return;
                    }
                }
            }

            user.Time = DateTime.Now;
            _userDataBase.Add(user);
            Console.WriteLine("The User is created");
        }
    }
}
