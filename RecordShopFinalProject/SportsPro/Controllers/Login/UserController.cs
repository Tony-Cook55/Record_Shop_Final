using RecordShop.Models.Login;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace RecordShop.Controllers.Login
{


    [Authorize(Roles = "Admin")]
    /*[Authorize]*/ // IF USER DOSENT HAVE THE PERMISSIONS TAKES THEM TO LOGIN PAGE From The AccountController Login Action
    public class UserController : Controller
    {
        private UserManager<User> userManager;
        private RoleManager<IdentityRole> roleManager;

        private SignInManager<User> signInManager;


        public UserController(UserManager<User> userManager, RoleManager<IdentityRole> roleManager)
        {
            this.userManager = userManager;
            this.roleManager = roleManager;
        }



        public async Task<IActionResult> ManageUsers()
        {
            List<User> users = new List<User>();

            foreach (User user in userManager.Users)
            {
                user.RoleNames = await userManager.GetRolesAsync(user);
                users.Add(user);
            }


            UserViewModel model = new UserViewModel
            {
                Users = users,
                Roles = roleManager.Roles
            };


            return View(model);
        }





        /* ++++++++++++ ADD USER ++++++++++++ */
        public async Task<IActionResult> GetAddUserPage()
        {
            return View(viewName: "AddNewUser", model: new RegisterViewModel());
        }



        [HttpPost]
        public async Task<IActionResult> AddNewUser(RegisterViewModel model)
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
                    /*await signInManager.SignInAsync(user, isPersistent: false);*/
                    return RedirectToAction("ManageUsers");
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                }
            }

            return RedirectToAction("ManageUsers");
        }
        /* ++++++++++++ ADD USER ++++++++++++ */





        /* ----------- DELETE USER ----------- */
        [HttpPost]
        public async Task<IActionResult> DeleteUser(string id)
        {
            User user = await userManager.FindByIdAsync(id);

            if (user != null)
            {
                IdentityResult result = await userManager.DeleteAsync(user);
                if (!result.Succeeded)
                {
                    string errorMessage = "";
                    foreach (IdentityError error in result.Errors)
                    {
                        errorMessage += error.Description + " | ";
                    }
                    TempData["message"] = errorMessage;
                }
            }

            return RedirectToAction("ManageUsers");
        }
        /* ----------- DELETE USER ----------- */





        /* ++++++++++++ ADD ROLE ++++++++++++ */
        [HttpPost]
        public async Task<IActionResult> CreateAdminRole()
        {
            await roleManager.CreateAsync(new IdentityRole("Admin"));

            return RedirectToAction("ManageUsers");
        }




        [HttpPost]
        public async Task<IActionResult> AddToAdmin(string id)
        {
            IdentityRole adminRole = await roleManager.FindByNameAsync("Admin");

            if (adminRole == null)
            {
                TempData["message"] = "Admin role doestn exist, Click Create Admin Role BUtotn To Create It";
            }
            else
            {
                User user = await userManager.FindByIdAsync(id);
                await userManager.AddToRoleAsync(user, adminRole.Name);
            }

            return RedirectToAction("ManageUsers");
        }

        /* ++++++++++++ ADD ROLE ++++++++++++ */



        /* ---------- DELETE ROLE ---------- */
        [HttpPost]
        public async Task<IActionResult> DeleteRole(string id)
        {
            IdentityRole role = await roleManager.FindByIdAsync(id);

            await roleManager.DeleteAsync(role);

            return RedirectToAction("ManageUsers");
        }




        [HttpPost]
        public async Task<IActionResult> RemoveFromAdmin(string id)
        {
            User user = await userManager.FindByIdAsync(id);

            await userManager.RemoveFromRoleAsync(user, "Admin");

            return RedirectToAction("ManageUsers");
        }
        /* ---------- DELETE ROLE ---------- */


    }
}
