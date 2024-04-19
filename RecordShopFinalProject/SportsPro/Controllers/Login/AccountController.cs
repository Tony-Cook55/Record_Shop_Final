using RecordShop.Models.Login;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace RecordShop.Controllers.Login
{
    public class AccountController : Controller
    {



        private UserManager<User> userManager;
        private SignInManager<User> signInManager;

        public AccountController(UserManager<User> userManager, SignInManager<User> signInManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
        }



        /* IF A USER DOES NOT HAVE THE ROLE OF ADMIN THIS PAGE WILL BE DISPLAYED */
        public ViewResult AccessDenied()
        {
            return View();
        }




        public IActionResult Index()
        {
            return View();
        }



        /* ++++++++++++++ REGISTER ++++++++++++++ */
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = new User
                {
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    UserName = model.UserName,
                    Email = model.Email
                };

                var result = await userManager.CreateAsync(user, model.Password);

                if (result.Succeeded)
                {
                    await signInManager.SignInAsync(user, isPersistent: false);
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                }
            }

            return View(model);
        }
        /* ++++++++++++++ REGISTER ++++++++++++++ */






        /* ~~~~~~~~~~~~~~~ LOGIN ~~~~~~~~~~~~~~~ */

        [HttpGet]
        public IActionResult Login(string returnUrl = "")
        {
            var model = new LoginViewModel { ReturnUrl = returnUrl };
            return View(model);
        }


        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var result = await signInManager.PasswordSignInAsync(
                    model.UserName,
                    model.Password,
                    isPersistent: model.RememberMe,
                    lockoutOnFailure: false
                );

                if (result.Succeeded)
                {
                    if (!string.IsNullOrEmpty(model.ReturnUrl) && Url.IsLocalUrl(model.ReturnUrl))
                    {
                        return Redirect(model.ReturnUrl);
                    }
                    else
                    {
                        return RedirectToAction("Index", "Home");
                    }
                }
            }


            ModelState.AddModelError("", "Invalid Username or Password");
            return View(model);

        }
        /* ~~~~~~~~~~~~~~~ LOGIN ~~~~~~~~~~~~~~~ */






        /* -------------- LOGOUT -------------- */
        [HttpPost]
        public async Task<IActionResult> LogOut()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

        /* -------------- LOGOUT -------------- */










        /* ccccccccccc CHANGE PASSWORD ccccccccccc */
        [HttpGet]
        public IActionResult ChangePassword()
        {
            var model = new ChangePasswordViewModel
            {
                Username = User.Identity?.Name ?? ""
            };

            return View(model);
        }



        [HttpPost]
        public async Task<IActionResult> ChangePassword(ChangePasswordViewModel model)
        {
            if (ModelState.IsValid)
            {
                User user = await userManager.FindByNameAsync(model.Username);

                var result = await userManager.ChangePasswordAsync(user, model.OldPassword, model.NewPassword);

                if (result.Succeeded)
                {
                    TempData["message"] = "Password Has Been Changed Successfully";
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    foreach (IdentityError error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                }
            }

            return View(model);
        }

        /* ccccccccccc CHANGE PASSWORD ccccccccccc */



    }
}
