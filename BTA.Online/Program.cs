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


            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Welcome to Internet Banking!");
            Console.WriteLine("");
            Console.WriteLine("Changes number: ");
            Console.WriteLine("1. Autorizations");
            Console.WriteLine("2. Registrations");
            Console.WriteLine("3. Exit");

            int ch = Convert.ToInt32(Console.ReadLine());

            switch(ch)

            {
                case 1:
                    {
                        string IIN;
                        string Password;
                        Console.Clear();
                        Console.WriteLine("Changes IIN: ");
                        IIN = Console.ReadLine();
                        Console.WriteLine("Changes Password: ");
                        Password = Console.ReadLine();
                        User users = userService.GetUser(IIN, Password);
                        if (users == null)
                        {
                            Console.WriteLine("Your IIN or Password doesn't corrects....!");
                        }
                        else
                        {
                            Console.WriteLine("Welcome {0}", users.FirstName);
                        }
                    }
                    break;
                    case 2:
                    {
                        #region Regions

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
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        #endregion
                    }
                    break;
            }

        }
    }
}
