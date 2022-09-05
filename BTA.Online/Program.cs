using BTA.Online.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTA.Online
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UserService userService1 = new UserService();
            UserService userService = userService1;



            string message = "";
            User user = new User();
            user.Accounts = null;
            user.Birth = new DateTime(1996, 09, 29);
            user.IIN = "960929300565";
            user.FirstName = "Darkhan";
            user.SecondName = "Lukmankhakim";
            user.Password = "123";
            //user.Age = 26;
            user.Sex = "M";



            if (userService.Registration(user, out message))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(message);
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(message);
                Console.ForegroundColor= ConsoleColor.White;
            }

        }
    }
}
