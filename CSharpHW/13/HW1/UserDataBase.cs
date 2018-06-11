using System;
using System.Collections.Generic;

namespace HW1
{
    class UserDataBase: IUserDataBase
    {
        private bool _disposed;

        public List<IUser> UsersList { get; set; }

        public UserDataBase()
        {
            UsersList = new List<IUser>();
        }

        public void Add(IUser user)
        {
            if (_disposed)
            {
                throw new ObjectDisposedException("UserDataBase");
            }

            UsersList.Add(user);
        }

        public IUser Search(string name)
        {
            foreach (var item in UsersList)
            {
                if (item.Name == name)
                {
                    return item;
                }
            }
            return null;
        }

        public void GetList(bool clean)
        {
            if (!_disposed)
            {
                if (clean)
                {
                    foreach (var item in UsersList)
                    {
                        if (string.IsNullOrEmpty(item.Name))
                        {
                            Console.WriteLine(item.Email);
                        }
                        else
                        {
                            Console.WriteLine(item.Name);
                        };
                    }
                }
            }
            _disposed = true;
        }

        public void Dispose()
        {
            GetList(true);
            UsersList.Clear();
            GC.SuppressFinalize(this);
        }
    }
}
