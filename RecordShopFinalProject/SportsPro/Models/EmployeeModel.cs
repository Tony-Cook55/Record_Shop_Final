using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace RecordShop.Models
{
    public class EmployeeModel
    {


        // Read-Only Property for the /slug in the Program.cs file   This Shows the FirstName and the Last Name
        public string Slug => FirstName?.Replace(" ", "-").ToLower() + "-" + LastName?.Replace(" ", "-").ToLower()/* + "-" + Price?.ToString()*/;






        // Primary Key
        public int EmployeeModelId { get; set; }



        [Required(ErrorMessage = "Please Enter a First Name")]
        [StringLength(30, MinimumLength = 1, ErrorMessage = "First Names Must Have At Least 1 to 30 Characters")]
        public string? FirstName { get; set; } = string.Empty;



        [Required(ErrorMessage = "Please Enter a Last Name")]
        [StringLength(30, MinimumLength = 1, ErrorMessage = "Last Names Must Have At Least 1 to 30 Characters")]
        public string? LastName { get; set; } = string.Empty;




        [Required(ErrorMessage = "Please Enter An Email")]
        [StringLength(40, MinimumLength = 1, ErrorMessage = "Email Must Have At Least 1 to 40 Characters")]
        // Valid inputs: user@example.com, user.name@example.com, user123@example.com, user.name123@example.co.uk, user+name@example.com, user_name@example.com, user-name@example.com, user123@example.co, user@example.co.uk, user@sub.domain.com
        [RegularExpression(@"[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,4}$", ErrorMessage = "Please enter a valid email address")]
        [Remote(action: "CheckEmailExists", controller: "EmployeeValidation", AdditionalFields = nameof(EmployeeModelId))]
        public string? Email { get; set; } = string.Empty;



        [Required(ErrorMessage = "Please Enter a Phone Number")]
        // Supported formats: -  (xxx) xxx-xxxx  -  xxx-xxx-xxxx  -  xxx xxx xxxx  -  xxxxxxxxxx
        [RegularExpression(@"^\(?\d{3}\)?[-.\s]?\d{3}[-.\s]?\d{4}$", ErrorMessage = "Please Enter a valid Phone Number")]
        /*[RegularExpression(@"^\(\d{3}\)\s*\d{3}-\d{4}$", ErrorMessage = "Please enter a valid phone number in the format (999) 999-9999")]*/
        public string? PhoneNumber { get; set; } = string.Empty;







    }
}
