namespace RecordShop.Models
{
        // We Inherit the IncidentModel to allow all of its items to be passed into the EditIncident
    public class IncidentAddEditViewModel : IncidentModel
    {
        public List<CustomerModel>? Customers { get; set; }
        public List<ProductModel>? Products { get; set; }
        public List<EmployeeModel>? Employees { get; set; }
        public IncidentModel? CurrentIncident { get; set; }
        public string? AddOrEdit { get; set; } // Specifies whether the page is for an Add or Edit operation

    }
}
