using System.Collections.ObjectModel;
using System.ComponentModel;

namespace Goals_Site.Models
{
    public class Job
    {
        public int JobId { get; set; } // hidden ID
        [DisplayName("Job_Number")]
        public int Job_number { get; set; } // User Inputtable
        [DisplayName("Date")]
        public string Date { get; set; }
        [DisplayName("Start")]
        public string Start { get; set; }
        [DisplayName("Finish")]
        public string Est_finish_time { get; set; }
        [DisplayName("Scope")]
        public string Scope { get; set; }

        // Manager Objects and ids
        [DisplayName("Project Manager")]
        public int Project_managerId { get; set; } 
        public Project_manager Project_manager { get; set; }
        [DisplayName("Sales Manager")]
        public int Sales_managerId { get; set; }
        public Sales_manager Sales_manager { get; set; }

        // Client Object and id
        [DisplayName("Client")]
        public int ClientId { get; set; }
        public Client Client { get; set; }

        // Site Objects and ids
        [DisplayName("From Site:")]
        public string From_site { get; set; }
        [DisplayName("To Site:")]
        public string To_site { get; set; }

        public int From_siteID { get; set; }
        public string To_siteID { get; set; }

    }
}
