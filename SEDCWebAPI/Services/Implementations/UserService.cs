using SEDCWebAPI.Services.Interfaces;
using SEDCWebApplication.BLL.Logic.Interfaces;
using SEDCWebApplication.BLL.Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEDCWebAPI.Services.Implementations
{
    public class UserService : IUserService
    {
        private readonly IUserManager _userManager;
        public UserService(IUserManager userManager)
        {
            _userManager = userManager;
        }

        public UserDTO Authenticate(string username, string password)
        {
            UserDTO user = _userManager.GetUserByUserNameAndPassword(username, password);
            return user;
        }
    }
}
