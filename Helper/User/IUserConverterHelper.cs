using JETech.JEDayCare.Core.User.Models;
using JETech.JEDayCare.Web.Models;

namespace JETech.JEDayCare.Web.Helper.User
{
    public interface IUserConverterHelper
    {
        LoginModel ToLoginModel(LoginViewModel login);
        UserModel ToUserModel(AddUserViewModel model);
    }
}