using System.Collections.Generic;

namespace HW1
{
    interface IUserDataBase
    {
        List<IUser> UsersList { get; set; }
        void Add(IUser user);
        void GetList(bool clean);
        IUser Search(string name);
    }
}
