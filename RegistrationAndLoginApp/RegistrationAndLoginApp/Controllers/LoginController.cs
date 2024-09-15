using Microsoft.AspNetCore.Mvc;
using RegistrationAndLoginApp.Models;

namespace RegistrationAndLoginApp.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {

            return View();
        }

        public IActionResult ProcessLogin(UserModel userModel)
        {

            if (userModel.UserName == "BillGates" && userModel.Password == "bigbucks")
            {

                return View("LoginSuccess", userModel);

            } else
            {
                return View("LoginFailure", userModel);
            }


            
        }


    }
}
