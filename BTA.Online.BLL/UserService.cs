using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTA.Online.BLL
{

    public class UserService
    {
      
        public UserService(string Path)
        {
            this.Path = Path;    
        }
        private string Path { get; set; }
        //public string UserName { get; set; }
        public List<User> Users_ { get; set; }
        public UserService()
        {
        }

        public bool Registration(User user, out string message)
        {
            try
            {
                if (GetUser(user.IIN) != null)
                {
                    message = "Пользователь с ИИН:" + user.IIN + "уже зарегестрирован!";
                    return false;
                }
                else
                {
                    using (var db = new LiteDatabase(Path))
                    {
                        var users = db.GetCollection<User>("Users");
                        users.Insert(user);

                        message = "Successfull";
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                message = ex.Message;
                return false;
            }
        }

        public User GetUser(string iin)
        {
            User user = null;
            try
            {
                using (var db = new LiteDatabase(Path))
                {
                    var users = db.GetCollection<User>("Users");
                    user = users.FindOne(f => f.IIN == iin);
                }
            }
            catch
            {
                user = null;
            }
            return user;
        }
        public User[] Users { get; set; }
    }
}
