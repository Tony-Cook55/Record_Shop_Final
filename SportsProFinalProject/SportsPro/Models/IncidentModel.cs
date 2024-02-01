using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations;

namespace RecordShop.Models
{
    public class IncidentModel
    {

        // Read-Only Property for the /slug in the Program.cs file   This Shows the FirstName and the Last Name
        public string Slug => Title?.Replace(" ", "-").ToLower() + "-" + Customer.CustomerFirstName?.Replace(" ", "-").ToLower();






        // Primary Key
        public int IncidentModelId { get; set; }



        [Required(ErrorMessage = "Please Enter a Title")]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "Titles Must Have At Least 1 to 50 Characters")]
        public string? Title { get; set; } = string.Empty;


        [Required(ErrorMessage = "Please Enter a Description")]
        [StringLength(100, MinimumLength = 1, ErrorMessage = "Descriptions Must Have At Least 1 to 100 Characters")]
        public string? Description { get; set; } = string.Empty;


        [Required(ErrorMessage = "Please Enter The Date Opened")]
        public DateTime DateOpened { get; set; }


        public DateTime? DateClosed { get; set; }





        // Foreign Key Property
        [Required(ErrorMessage = "Please Enter a Customer")]
        public int? CustomerModelId { get; set; }

        // NAVIGATION PROPERTY
        [ValidateNever]
        public CustomerModel Customer { get; set; } = null!;





        // Foreign Key Property
        [Required(ErrorMessage = "Please Enter a Product")]
        public int? ProductModelId { get; set; }

        // NAVIGATION PROPERTY
        [ValidateNever]
        public ProductModel Product { get; set; } = null!;




        // Foreign Key Property
        [Required(ErrorMessage = "Please Enter a Employee")]
        public int EmployeeModelId { get; set; }

        // NAVIGATION PROPERTY
        [ValidateNever]
        public EmployeeModel Employee { get; set; } = null!;





    }
}
