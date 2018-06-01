using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1
{
    class Program
    {
        static void Main(string[] args)
        {
            DeepCopyExamplePrint();
            ShallowCopyExample();
        }

        public static void DeepCopyExamplePrint()
        {
            Console.WriteLine("DeepCopyExample" + '\n');

            Console.WriteLine("User1");
            var user1 = new User("User1FirstName", "User1LastName", "User1AdditionalInfo");
            Console.WriteLine(user1);

            Console.WriteLine("User2");
            var user2 = user1.DeepCopyUser();
            Console.WriteLine(user2);

            Console.WriteLine("Edited Value in User2" + '\n');

            user2.LastName = "EditLastName";

            Console.WriteLine("User1");
            Console.WriteLine(user1);

            Console.WriteLine("User2");
            Console.WriteLine(user2);
        }

        public static void ShallowCopyExample()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("ShallowCopyExample" + '\n');

            Console.WriteLine("User1");
            var user1 = new User("User1FirstName", "User1LastName", "User1AdditionalInfo");
            Console.WriteLine(user1);

            Console.WriteLine("User2");
            var user2 = user1;
            Console.WriteLine(user2);

            Console.WriteLine("Edited Value in User2" + '\n');

            user2.LastName = "EditLastName";

            Console.WriteLine("User1");
            Console.WriteLine(user1);

            Console.WriteLine("User2");
            Console.WriteLine(user2);

            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
