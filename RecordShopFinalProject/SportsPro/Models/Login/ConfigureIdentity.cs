
using Microsoft.AspNetCore.Identity;

namespace RecordShop.Models.Login
{
    public class ConfigureIdentity
    {
        public static async Task CreateAdminUserAsync(IServiceProvider provider)
        {
            var roleManager = provider.GetRequiredService<RoleManager<IdentityRole>>();

            var userManager = provider.GetRequiredService<UserManager<User>>();

            string firstName = "Tony";
            string lastName = "Cook";
            string username = "TonyCook55";
            string password = "Fuggetaboutit55!"; // P@ssw0rd
            string roleName = "Admin";

            //If Role doesn't exist, create it on start up creating an admin role with the above items
            if(await roleManager.FindByNameAsync(roleName) == null)
            {
                await roleManager.CreateAsync(new IdentityRole(roleName));
            }

            // If Username Doesn't Exist Create it
            if (await userManager.FindByNameAsync(username) == null)
            {
                User user = new User
                {
                    FirstName = firstName,
                    LastName = lastName,
                    UserName = username,
                };

                var result = await userManager.CreateAsync(user, password);

                if(result.Succeeded)
                {
                    await userManager.AddToRoleAsync(user, roleName);
                }
            }
        }
    }
}
