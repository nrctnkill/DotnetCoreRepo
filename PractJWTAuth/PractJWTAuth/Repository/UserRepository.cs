using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PractJWTAuth.Interfaces;
using PractJWTAuth.Models;
namespace PractJWTAuth.Repository
{
    public class UserRepository:IUserRepository
    {
        private readonly List<UserDTO> users = new List<UserDTO>();

        public UserRepository()
        {
            users.Add(new UserDTO { UserName = "ravi", Password = "ravi123", Role ="manager"});
            users.Add(new UserDTO { UserName = "neelima", Password = "neelima123", Role = "admin" });
            users.Add(new UserDTO { UserName = "nishal", Password = "nishal123", Role = "developer" });
        }

        public UserDTO GetUser(UserModel userModel)
        {
            return users.Where(x => x.UserName.ToLower() == userModel.UserName.ToLower() && x.Password.ToLower() == userModel.Password.ToLower()).FirstOrDefault();
        }
    }
}
