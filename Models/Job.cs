using System.Collections.ObjectModel;

namespace Goals_Site.Models
{
    public class Job
    {
        public int JobId { get; set; } // hidden ID
        public int Job_number { get; set; } // User Inputtable
        public string Date { get; set; }
        public string Start { get; set; }
        public string Est_finish_time { get; set; }
        public string Scope { get; set; }

        // Manager Objects and ids
        public int Project_managerId { get; set; } 
        public Project_manager Project_manager { get; set; }
        public int Sales_managerId { get; set; }
        public Sales_manager Sales_manager { get; set; }

        // Client Object and id
        public int ClientId { get; set; }
        public Client Client { get; set; }

        // Site Objects and ids
        public int From_siteId { get; set; }
        public Site From_site { get; set; }
        public int To_siteId { get; set; }
        public Site To_site { get; set; }




    }
}
