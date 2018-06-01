using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1
{
    class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string AdditionalInfo { get; set; }

        public User(string firstName, string lastName, string additionalInfo)
        {
            FirstName = firstName;
            LastName = lastName;
            AdditionalInfo = additionalInfo;
        }

        public User DeepCopyUser()
        {
            return new User(FirstName, LastName, AdditionalInfo);
        }

        public override string ToString()
        {
            return "FirstName " + FirstName + '\n'
                + "LastName " + LastName + '\n'
                + "Additional Info" + AdditionalInfo + '\n';
        }
    }
}
