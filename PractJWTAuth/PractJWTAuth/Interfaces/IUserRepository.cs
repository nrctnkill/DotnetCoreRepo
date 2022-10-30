using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PractJWTAuth.Models;
namespace PractJWTAuth.Interfaces
{
    public interface IUserRepository
    {
        UserDTO GetUser(UserModel userMode);
    }
}
