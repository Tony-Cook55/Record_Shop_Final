namespace RecordShop.Models
{
    public class IncidentListViewModel
    {
        public List<IncidentModel>? IncidentItems { get; set; }


        // Specify whether to display all incidents, unassigned incidents, or open incidents
        public string? IncidentDisplayMode { get; set; }

    }
}
