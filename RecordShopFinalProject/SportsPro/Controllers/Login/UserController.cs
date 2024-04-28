using RecordShop.Models.Login;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace RecordShop.Controllers.Login
{


    [Authorize(Roles = "Admin")]
    /*[Authorize]*/ // IF USER DOSENT HAVE THE PERMISSIONS TAKES THEM TO LOGIN PAGE From The AccountController Login Action
    public class UserController : Controller
    {
        private UserManager<User> userManager;
        private RoleManager<IdentityRole> roleManager;

        /*private SignInManager<User> signInManager;*/


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

            // Count the total number of users
            int TotalUsers = users.Count;
            ViewBag.TotalItemCount = TotalUsers;


            return View(model);
        }





        /* ++++++++++++ ADD USER ++++++++++++ */
        public IActionResult GetAddUserPage()
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

                    TempData["ACCOUNTMessage"] = $"New User Successfully Registered.";
                    TempData["ACCOUNToperation"] = $"REGISTER_USER"; // USED FOR ADDING CORRESPONDING BG COLOR FOR OPERATION

                    return RedirectToAction(actionName: "ManageUsers");
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
                    TempData["CRUDMessage"] = $"{errorMessage}";
                    TempData["CRUDOperation"] = $"CRUD_DELETED"; // USED FOR ADDING CORRESPONDING BG COLOR FOR OPERATION
                }
            }

            TempData["CRUDMessage"] = $"{user.FirstName} Has Been Successfully Deleted";
            TempData["CRUDOperation"] = $"CRUD_DELETED"; // USED FOR ADDING CORRESPONDING BG COLOR FOR OPERATION

            return RedirectToAction("ManageUsers");
        }
        /* ----------- DELETE USER ----------- */





        /* ++++++++++++ ADD ROLE ++++++++++++ */
        [HttpPost]
        public async Task<IActionResult> CreateAdminRole()
        {
            await roleManager.CreateAsync(new IdentityRole("Admin"));

            TempData["CRUDMessage"] = $"Admin Role Has Been Added";
            TempData["CRUDOperation"] = $"CRUD_ADDED"; // USED FOR ADDING CORRESPONDING BG COLOR FOR OPERATION

            return RedirectToAction("ManageUsers");
        }




        [HttpPost]
        public async Task<IActionResult> AddToAdmin(string id)
        {
            IdentityRole adminRole = await roleManager.FindByNameAsync("Admin");

            if (adminRole == null)
            {
                TempData["CRUDMessage"] = $"Admin Role Doesn't Exist, Click Create Admin Role Button To Create it.";
                TempData["CRUDOperation"] = $"CRUD_DELETED"; // USED FOR ADDING CORRESPONDING BG COLOR FOR OPERATION
            }
            else
            {
                User user = await userManager.FindByIdAsync(id);
                await userManager.AddToRoleAsync(user, adminRole.Name);

                TempData["CRUDMessage"] = $"{user.FirstName} Has Been Added to {adminRole.Name} Role";
                TempData["CRUDOperation"] = $"CRUD_ADDED"; // USED FOR ADDING CORRESPONDING BG COLOR FOR OPERATION
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

            TempData["CRUDMessage"] = $"{role} Role Has Been Deleted";
            TempData["CRUDOperation"] = $"CRUD_DELETED"; // USED FOR ADDING CORRESPONDING BG COLOR FOR OPERATION

            return RedirectToAction("ManageUsers");
        }




        [HttpPost]
        public async Task<IActionResult> RemoveFromAdmin(string id)
        {
            User user = await userManager.FindByIdAsync(id);

            await userManager.RemoveFromRoleAsync(user, "Admin");

            TempData["CRUDMessage"] = $"{user.FirstName}'s Admin Role Has Been Removed";
            TempData["CRUDOperation"] = $"CRUD_DELETED"; // USED FOR ADDING CORRESPONDING BG COLOR FOR OPERATION

            return RedirectToAction("ManageUsers");
        }
        /* ---------- DELETE ROLE ---------- */


    }
}
