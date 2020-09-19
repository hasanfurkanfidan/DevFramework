using DevFramework.Core.CrossCuttingConcerns.Security.Web;
using DevFramework.Northwind.Business.Abstract;
using DevFramework.Northwind.Entities.ComplexTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Devframework.Northwind.Web.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        IUserService _userService;

        public AccountController(IUserService userService)
        {
            _userService = userService;
        }
        public string Login()
        {
            var user = _userService.GetByUserNameAndPassword("furkan", "12345");
            if (user != null)
            {
                AuthenticationHelper.CreateAuthCookie(new Guid(), user.UserName, user.Email, DateTime.Now.AddDays(15), _userService.GetUserRoles(user).Select(p=>p.RoleName).ToArray(), false, user.UserName, user.LastName);
                return "user is authenticated";

            }
            return "user is not authenticated";
        }
        
    }
}