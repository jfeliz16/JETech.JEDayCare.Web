using JETech.JEDayCare.Core.User.Models;
using JETech.JEDayCare.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JETech.JEDayCare.Web.Helper
{
    public class UserConverterHelper : IUserConverterHelper
    {
        public LoginModel ToLoginModel(LoginViewModel model)
        {
            return new LoginModel
            {
                Username = model.Username,
                Password = model.Password,
                RememberMe = model.RememberMe
            };
        }

        public UserModel ToUserModel(AddUserViewModel model) 
        {
            return new UserModel
            {
                UserName = model.Email,
                Email = model.Email,
                FirstName = model.FirstName,
                LastName = model.LastName,
                Password = model.Password,
                PasswordConfirm = model.PasswordConfirm
            };
        }
    }
}
