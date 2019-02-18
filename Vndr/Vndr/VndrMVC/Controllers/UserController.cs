using System;
using Microsoft.AspNetCore.Mvc;
using VendingService;
using VendingService.Exceptions;
using VendingService.Models;

namespace VndrMVC.Controllers
{
    public class UserController : BaseController
    {
        IVendingMachine _vm = null;

        public UserController(IVendingMachine vm) : base(vm)
        {
            _vm = vm;
        }

        [HttpGet]
        public ActionResult Login()
        {
            if (_vm.IsAuthenticated)
            {
                _vm.LogoutUser();
            }

            return View("Login");
        }

        [HttpPost]
        public ActionResult Login(LoginViewModel model)
        {
            ActionResult result = null;

            try
            {
                if (!ModelState.IsValid)
                {
                    throw new Exception();
                }

                _vm.LoginUser(model.Username, model.Password);

                result = RedirectToAction("Index", "Vending");
            }
            catch (Exception)
            {
                result = View("Login");
            }

            return result;
        }

        [HttpGet]
        public ActionResult Register()
        {
            if (_vm.IsAuthenticated)
            {
                _vm.LogoutUser();
            }

            return View("Register");
        }

        [HttpPost]
        public ActionResult Register(RegisterViewModel model)
        {
            ActionResult result = null;

            try
            {
                if (!ModelState.IsValid)
                {
                    throw new Exception();
                }

                try
                {
                    User userModel = new User();
                    userModel.ConfirmPassword = model.ConfirmPassword;
                    userModel.Password = model.Password;
                    userModel.FirstName = model.FirstName;
                    userModel.LastName = model.LastName;
                    userModel.Username = model.Username;
                    userModel.Email = model.Email;
                    _vm.RegisterUser(userModel);
                }
                catch (UserExistsException)
                {
                    ModelState.AddModelError("invalid-user", "The username is already taken.");
                    throw;
                }

                result = RedirectToAction("Index", "Vending");
            }
            catch (Exception)
            {
                result = View("Register");
            }

            return result;
        }
    }
}
