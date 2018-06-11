using System;

namespace HW1
{
    class Authenticator : IAuthenticator
    {
        public void AuthenticateUser(IUser user, IUserDataBase userDataBase)
        {
            var resultSearch = userDataBase.Search(user.Name);

            if (resultSearch!=null)
            {
                if (resultSearch.Password == user.Password)
                {
                    Console.WriteLine(resultSearch.Time);
                    resultSearch.Time = DateTime.Now;
                    return;
                }

                Console.WriteLine("Password is incorrect");
                return;
            }

            user.Time = DateTime.Now;
            userDataBase.Add(user);
            Console.WriteLine("The User is created");
        }
    }
}
